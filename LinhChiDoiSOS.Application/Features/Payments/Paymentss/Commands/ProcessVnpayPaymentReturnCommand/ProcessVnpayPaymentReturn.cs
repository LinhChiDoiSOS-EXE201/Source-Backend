using AutoMapper;
using LinhChiDoiSOS.Application.Common.Base;
using LinhChiDoiSOS.Application.Common.Exceptions;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Constrants;
using LinhChiDoiSOS.Application.Features.Payments.Merchants.Dtos;
using LinhChiDoiSOS.Application.Features.Payments.Paymentss.Commands.ProcessVnpayPaymentIpnCommand;
using LinhChiDoiSOS.Application.Features.Payments.Paymentss.Dtos;
using LinhChiDoiSOS.Domain.Entities.Payments;
using LinhChiDoiSOS.Servicess.VnPay.Config;
using LinhChiDoiSOS.Servicess.VnPay.Response;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.Payments.Paymentss.Commands.ProcessVnpayPaymentReturn
{
    public class ProcessVnpayPaymentReturn : VnpayPayResponse,
        IRequest<(PaymentReturnDtos, string)>
    {
    }

    public class ProcessVnpayPaymentReturnHandler :
        IRequestHandler<ProcessVnpayPaymentReturn, (PaymentReturnDtos, string)>
    {
        private ILinhChiDoiSOSDbContext _dbContext;
        private IMapper _mapper;
        private readonly VnpayConfig vnpayConfig;
        private readonly IMediator mediator;

        public ProcessVnpayPaymentReturnHandler(ILinhChiDoiSOSDbContext dbContext,
            IMapper mapper,
            IOptions<VnpayConfig> vnpayConfigOptions,
            IMediator mediator)
        {
            this._dbContext = dbContext;
            this._mapper = mapper;
            this.vnpayConfig = vnpayConfigOptions.Value;
            this.mediator = mediator;
        }
        public async Task<(PaymentReturnDtos, string)> Handle(ProcessVnpayPaymentReturn request, CancellationToken cancellationToken)
        {
            string returnUrl = string.Empty;
            var result = (new PaymentReturnDtos(), "");

            try {
                var resultData = new PaymentReturnDtos();
                var isValidSignature = request.IsValidSignature(vnpayConfig.HashSecret);

                if (isValidSignature) {
                    var payment = await _dbContext.Payment
                        .Where(p => p.Id == Guid.Parse(request.vnp_TxnRef))
                        .SingleOrDefaultAsync();

                    if (payment != null) {
                        var merchant = await _dbContext.Merchant
                            .Where(m => m.Id == payment.MerchantId)
                            .SingleOrDefaultAsync();

                        // update transaction
                        if (payment.RequiredAmount == (request.vnp_Amount / 100)) {
                            if (payment.PaymentStatus != "0") {
                                string message = "";
                                string status = "";

                                if (request.vnp_ResponseCode == "00" &&
                                   request.vnp_TransactionStatus == "00") {
                                    status = "0";
                                    message = "Tran success";
                                }
                                else {
                                    status = "-1";
                                    message = "Tran error";
                                }

                                /// Update database
                                var transaction = new PaymentTransaction
                                {
                                    TranMessage = message,
                                    TranPayload = JsonConvert.SerializeObject(request),
                                    TranStatus = status,
                                    TranAmount = request.vnp_Amount,
                                    TranDate = DateTime.Now,
                                    PaymentId = Guid.Parse(request.vnp_TxnRef),
                                    TranRefId = payment.PaymentRefId
                                };
                                _dbContext.PaymentTransaction.Add(transaction);
                                await _dbContext.SaveChangesAsync();
                                /// Confirm success
                                var transactionExist = await _dbContext.PaymentTransaction
                                    .Where(t => t.Id == transaction.Id).SingleOrDefaultAsync();
                                if (transactionExist == null) {
                                    throw new BadRequestException("04, Input required data");
                                }
                            }
                            else {
                                throw new BadRequestException("04, Invalid amount");
                            }
                        }
                        returnUrl = merchant?.MerchantReturnUrl ?? string.Empty;
                    }
                    else {
                        resultData.PaymentStatus = "11";
                        resultData.PaymentMessage = "Can't find payment at payment service";
                    }

                    if (request.vnp_ResponseCode == "00") {
                        resultData.PaymentStatus = "00";
                        resultData.PaymentId = payment.Id.ToString();
                        ///TODO: Make signature
                        resultData.Signature = Guid.NewGuid().ToString();
                    }
                    else {
                        resultData.PaymentStatus = "10";
                        resultData.PaymentMessage = "Payment process failed";
                    }

                    result = (resultData, returnUrl);
                }
                else {
                    resultData.PaymentStatus = "99";
                    resultData.PaymentMessage = "Invalid signature in response";

                }
            }
            catch (Exception ex) {
                throw new BadRequestException(ex.Message);
            }

            return result;
        }
    }
}
