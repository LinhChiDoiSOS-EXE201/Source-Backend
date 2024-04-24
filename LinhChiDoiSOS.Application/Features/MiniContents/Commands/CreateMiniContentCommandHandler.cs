using AutoMapper;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Common.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.MiniContents.Commands
{
    public class CreateMiniContentCommandHandler : IRequestHandler<CreateMiniContentCommand, SOSResponse>
    {
        private readonly IMapper _mapper;
        private readonly ILinhChiDoiSOSDbContext _dbContext;

        public CreateMiniContentCommandHandler(ILinhChiDoiSOSDbContext dbContext, IMapper mapper)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<SOSResponse> Handle(CreateMiniContentCommand request, CancellationToken cancellationToken)
        {
            var checkExistedItems = _dbContext.MiniContent
                .Where(x => x.EmergencyDetailId == request.EmergencyDetailId && !x.IsDelete)
                .FirstOrDefault();
            if(checkExistedItems != null || checkExistedItems == null)
            {
                throw new Exception("EmergencyDetailId is existed or not existed");
            } else
            {
                var newItems = new MiniContent
                {
                    EmergencyDetailId = request.EmergencyDetailId,
                    ContentUrl = request.ContentUrl,
                    Content = request.Content,
                };
                _dbContext.MiniContent.Add(newItems);
                await _dbContext.SaveChangesAsync();
            }
            return new SOSResponse
            {
                Message = "Create Successfully"
            };
        }
    }
}