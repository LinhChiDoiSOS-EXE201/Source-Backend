using AutoMapper;
using LinhChiDoiSOS.Application.Common.Base;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Constrants;
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

namespace LinhChiDoiSOS.Application.Features.Payments.Paymentss.Commands.ProcessVnpayPaymentIpnCommand
{
    public class ProcessVnpayPaymentIpn : VnpayPayResponse,
        IRequest<VnpayPayIpnResponse>
    {
    }

    public class ProcessVnpayPaymentIpnHandler :
        IRequestHandler<ProcessVnpayPaymentIpn, VnpayPayIpnResponse>
    {
        private ILinhChiDoiSOSDbContext _dbContext;
        private readonly ICurrentUserService currentUserService;
        private readonly VnpayConfig vnpayConfig;
        private IMapper _mapper;
        public ProcessVnpayPaymentIpnHandler(ILinhChiDoiSOSDbContext dbContext,
            ICurrentUserService currentUserService,
            IMapper mapper,
            IOptions<VnpayConfig> vnpayConfigOptions)
        {
            this._dbContext = dbContext;
            this.currentUserService = currentUserService;
            this._mapper = mapper;
            this.vnpayConfig = vnpayConfigOptions.Value;
        }
        public async Task<VnpayPayIpnResponse> Handle(
            ProcessVnpayPaymentIpn request, CancellationToken cancellationToken)
        {
            var resultData = new VnpayPayIpnResponse();

            try {
                var isValidSignature = request.IsValidSignature(vnpayConfig.HashSecret);

                if (isValidSignature) {
                    /// Get payment request
                    var payment = await _dbContext.Payment
                        .Where(p => p.Id == Guid.Parse(request.vnp_TxnRef))
                        .SingleOrDefaultAsync();

                    if (payment != null) {
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
                                if (transactionExist != null) {
                                    resultData.Set("00", "Confirm success");
                                }
                                else {
                                    resultData.Set("99", "Input required data");
                                }
                            }
                            else {
                                resultData.Set("02", "Order already confirmed");
                            }
                        }
                        else {
                            resultData.Set("04", "Invalid amount");
                        }
                    }
                    else {
                        resultData.Set("01", "Order not found");
                    }
                }
                else {
                    resultData.Set("97", "Invalid signature");
                }
            }
            catch (Exception ex) {
                /// TODO: process when exception
                resultData.Set("99", "Input required data");
            }

            return resultData;
        }
    }
}
