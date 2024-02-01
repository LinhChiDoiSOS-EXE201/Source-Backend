using AutoMapper;
using LinhChiDoiSOS.Application.Common.Exceptions;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Features.Payments.Paymentss.Dtos;
using LinhChiDoiSOS.Servicess.Momo.Config;
using LinhChiDoiSOS.Servicess.VnPay.Config;
using LinhChiDoiSOS.Servicess.ZaloPay.Config;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.Payments.Paymentss.Queries
{ 
    public class GetPayment : IRequest<PaymentDtos>
    {
        public string Id { get; set; } = string.Empty;
    }


    public class GetPaymentHandler : IRequestHandler<GetPayment, PaymentDtos>
    {
        private ILinhChiDoiSOSDbContext _dbContext;
        private readonly ICurrentUserService currentUserService;
        public readonly IMapper _mapper;

        public GetPaymentHandler(ILinhChiDoiSOSDbContext dbContext,
            ICurrentUserService currentUserService,
            IMapper mapper)
        {
            _dbContext = dbContext;
            this.currentUserService = currentUserService;
            _mapper = mapper;
        }
        public async Task<PaymentDtos> Handle(GetPayment request, CancellationToken cancellationToken)
        {
            try {
                var payment = await _dbContext.Payment
                    .Where(p => p.Id == Guid.Parse(request.Id) && !p.IsDelete)
                    .SingleOrDefaultAsync();
                if(payment == null) {
                    throw new NotFoundException($"Not Found paymentId {request.Id}");
                }
                var data = _mapper.Map<PaymentDtos>(payment);
                return data;
            }catch (Exception ex) {
                throw new BadRequestException(ex.Message);
            }
        }
    }
}
