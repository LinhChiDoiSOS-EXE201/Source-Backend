using LinhChiDoiSOS.Application.Common.Base;
using LinhChiDoiSOS.Application.Common.Exceptions;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Features.Payments.Paymentss.Dtos;
using LinhChiDoiSOS.Application.Models;
using LinhChiDoiSOS.Domain.Entities.Payments;
using LinhChiDoiSOS.Servicess.Momo.Config;
using LinhChiDoiSOS.Servicess.Momo.Request;
using LinhChiDoiSOS.Servicess.VnPay.Config;
using LinhChiDoiSOS.Servicess.VnPay.Request;
using LinhChiDoiSOS.Servicess.ZaloPay.Config;
using LinhChiDoiSOS.Servicess.ZaloPay.Request;
using LinhChiDoiSOS.Utils.Extensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.Payments.Paymentss.Commands
{
    public class CreatePayment : IRequest<PaymentLinkDtos>
    {
        public string PaymentContent { get; set; } = string.Empty;
        public string PaymentCurrency { get; set; } = string.Empty;
        public string PaymentRefId { get; set; } = string.Empty;
        public decimal? RequiredAmount { get; set; }
        //public DateTime? PaymentDate { get; set; } = DateTime.Now;
        //public DateTime? ExpireDate { get; set; } = DateTime.Now.AddMinutes(15);
        public string? PaymentLanguage { get; set; } = string.Empty;

        public string? MerchantId { get; set; } = string.Empty;
        public string? PaymentDestinationId { get; set; } = string.Empty;
        public CreatePaymentSignature CreatePaymentSignature { get; set; }
        public BookingCourse BookingCourse {  get; set; }
    }
    public class CreatePaymentSignature
    {
        public string? SignValue { get; set; } = string.Empty;
        public string? SignAlgo { get; set; } = string.Empty;
    }
    public class BookingCourse
    {
        public double? Price { get; set; }
        public string CustomerId { get; set; }

        // comboCourse => premium
        public string? NameComboCourse { get; set; }
    }

    public class CreatePaymentHandler : IRequestHandler<CreatePayment, PaymentLinkDtos>
    {
        private ILinhChiDoiSOSDbContext _dbContext;
        private readonly ICurrentUserService currentUserService;
        private readonly IConfiguration _configuration;
        private readonly VnpayConfig vnpayConfig;
        private readonly MomoConfig momoConfig;
        private readonly ZaloPayConfig zaloPayConfig;

        public CreatePaymentHandler(ILinhChiDoiSOSDbContext dbContext,
            ICurrentUserService currentUserService,
            IConfiguration configuration,
            IOptions<MomoConfig> momoConfigOptions,
            IOptions<ZaloPayConfig> zaloPayConfigOptions,
            IOptions<VnpayConfig> vnpayConfigOptions)
        {
            _dbContext = dbContext;
            this.currentUserService = currentUserService;
            _configuration = configuration;
            this.vnpayConfig = vnpayConfigOptions.Value;
            this.momoConfig = momoConfigOptions.Value;
            this.zaloPayConfig = zaloPayConfigOptions.Value;
        }
        public async Task<PaymentLinkDtos> Handle(CreatePayment request, CancellationToken cancellationToken)
        {
            try {
                var payment = new Payment
                {
                    PaymentContent = request.PaymentContent,
                    PaymentCurrency = request.PaymentCurrency,
                    PaymentRefId = request.PaymentRefId,
                    RequiredAmount = request.RequiredAmount,
                    PaymentDate = DateTime.Now,
                    ExpireDate = DateTime.Now.AddMinutes(15),
                    /*PaymentStatus = "0",*/
                    PaymentLanguage = request.PaymentLanguage,
                    MerchantId = Guid.Parse(request.MerchantId),
                    PaymentDestinationId = Guid.Parse(request.PaymentDestinationId),
                };
                _dbContext.Payment.Add(payment);
                
                var signature = new PaymentSignature
                {
                    SignValue = request.CreatePaymentSignature.SignValue,
                    SignAlgo = request.CreatePaymentSignature.SignAlgo,
                    SignOwn = request.MerchantId,
                    SignDate = DateTime.Now,
                    PaymentId = payment.Id,
                    IsValid = true,
                };
                _dbContext.PaymentSignature.Add(signature);

                await _dbContext.SaveChangesAsync();

                // check đích thanh toán
                var paymentUrl = string.Empty;
                var destinationExist = await _dbContext.PaymentDestination
                    .Where(d => d.Id == Guid.Parse(request.PaymentDestinationId))
                    .Select(d => d.DesShortName)
                    .SingleOrDefaultAsync();
                switch (destinationExist) {
                    case "VNPAY":
                        var vnpayPayRequest = new VnpayPayRequest(
                            vnpayConfig.Version,
                            vnpayConfig.TmnCode, 
                            DateTime.Now, 
                            currentUserService.IpAddress ?? string.Empty, 
                            request.RequiredAmount ?? 0, 
                            request.PaymentCurrency ?? string.Empty,
                            "other", 
                            request.PaymentContent ?? string.Empty, 
                            vnpayConfig.ReturnUrl, 
                            payment.Id.ToString() ?? string.Empty);
                        paymentUrl = vnpayPayRequest.GetLink(vnpayConfig.PaymentUrl, vnpayConfig.HashSecret);
                        break;
                    case "MOMO":
                        var momoOneTimePayRequest = new MomoOneTimePaymentRequest(momoConfig.PartnerCode,
                            payment.Id.ToString() ?? string.Empty, (long)request.RequiredAmount!, payment.Id.ToString() ?? string.Empty,
                            request.PaymentContent ?? string.Empty, momoConfig.ReturnUrl, momoConfig.IpnUrl, "captureWallet",
                            string.Empty);
                        momoOneTimePayRequest.MakeSignature(momoConfig.AccessKey, momoConfig.SecretKey);
                        (bool createMomoLinkResult, string? createMessage) = momoOneTimePayRequest.GetLink(momoConfig.PaymentUrl);
                        if (createMomoLinkResult) {
                            paymentUrl = createMessage;
                        }
                        else {
                            throw new BadRequestException(createMessage);
                        }
                        break;
                    case "ZALOPAY":
                        var zalopayPayRequest = new CreateZalopayPayRequest(zaloPayConfig.AppId, zaloPayConfig.AppUser,
                            DateTime.Now.GetTimeStamp(), (long)request.RequiredAmount!, DateTime.Now.ToString("yymmdd") + "_" + payment.Id.ToString() ?? string.Empty,
                            "zalopayapp", request.PaymentContent ?? string.Empty);
                        zalopayPayRequest.MakeSignature(zaloPayConfig.Key1);
                        (bool createZaloPayLinkResult, string? createZaloPayMessage) = zalopayPayRequest.GetLink(zaloPayConfig.PaymentUrl);
                        if (createZaloPayLinkResult) {
                            paymentUrl = createZaloPayMessage;
                        }
                        else {
                            throw new BadRequestException(createZaloPayMessage);
                        }
                        break;
                    default:
                        break;
                }
                return new PaymentLinkDtos
                {
                    PaymentId = payment.Id.ToString(),
                    PaymentUrl = paymentUrl,
                };
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.Message);
            }
        }
    }
}

