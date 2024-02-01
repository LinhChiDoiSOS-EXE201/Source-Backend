using LinhChiDoiSOS.Application.Common.Base;
using LinhChiDoiSOS.Application.Common.Exceptions;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Constrants;
using LinhChiDoiSOS.Application.Features.Payments.Merchants.Dtos;
using LinhChiDoiSOS.Domain.Entities.Payments;
using Mapster;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.Payments.Merchants.Commands
{
    public class CreateMerchant : IRequest<BaseResultWithData<MerchantDtos>>
    {
        public string? MerchantName { get; set; } = string.Empty;
        public string? MerchantWebLink { get; set; } = string.Empty;
        public string? MerchantIpnUrl { get; set; } = string.Empty;
        public string? MerchantReturnUrl { get; set; } = string.Empty;
    }

    public class CreateMerchantHandler : IRequestHandler<CreateMerchant, BaseResultWithData<MerchantDtos>>
    {
        private ILinhChiDoiSOSDbContext _dbContext;
        private readonly IConfiguration _configuration;
        private readonly ICurrentUserService currentUserService;

        public CreateMerchantHandler(
            IConfiguration configuration,
            ILinhChiDoiSOSDbContext dbContext,
            ICurrentUserService currentUserService)
        {
            _dbContext = dbContext;
            this.currentUserService = currentUserService;
            _configuration = configuration;
        }
        public Task<BaseResultWithData<MerchantDtos>> Handle(CreateMerchant request, CancellationToken cancellationToken)
        {
            var result = new BaseResultWithData<MerchantDtos>();
            try {
                var merchant = new Merchant
                {
                    MerchantName = request.MerchantName,
                    MerchantWebLink = request.MerchantWebLink,
                    MerchantIpnUrl = request.MerchantIpnUrl,
                    MerchantReturnUrl = request.MerchantReturnUrl,
                    CreateBy = currentUserService.UserId,
                    SecretKey = Guid.NewGuid().ToString(),
                };
                _dbContext.Merchant.Add(merchant);
                _dbContext.SaveChangesAsync();

                var merchantExist = _dbContext.Merchant.Where(m => m.Id == merchant.Id).SingleOrDefault();
                if (merchantExist == null) {
                    result.Set(false, MessageContants.Error);
                    result.Errors.Add(new BaseError()
                    {
                        Code = "Sql",
                        Message = "Cannot add Merchant"
                    });
                }
                else {
                    var resultData = request.Adapt<MerchantDtos>(); // dùng mapper sẽ nth này: _mapper.Map<MerchantDtos>(request),
                                                                    // nhớ khai báo mappForm bên kia, t sài đồ mới thử đây nha
                    resultData.Id = merchant.Id;
                    result.Set(true, MessageContants.OK, resultData);
                }
            }
            catch (Exception ex) {
                result.Set(false, MessageContants.Error);
                result.Errors.Add(new BaseError()
                {
                    Code = MessageContants.Exception,
                    Message = ex.Message,
                });
            }

            return Task.FromResult(result);
        }
    }
}
