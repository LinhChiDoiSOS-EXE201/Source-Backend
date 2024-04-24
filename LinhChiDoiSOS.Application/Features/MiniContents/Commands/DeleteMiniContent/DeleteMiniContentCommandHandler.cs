using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Common.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.MiniContents.Commands.DeleteMiniContent
{
    public class DeleteMiniContentCommandHandler : IRequestHandler<DeleteMiniContentCommand, SOSResponse>
    {
        private readonly ILinhChiDoiSOSDbContext _dbContext;

        public DeleteMiniContentCommandHandler(ILinhChiDoiSOSDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<SOSResponse> Handle(DeleteMiniContentCommand request, CancellationToken cancellationToken)
        {
            var checkMiniContentId = _dbContext.MiniContent
                .Where(x => x.Id == request.MiniContentId)
                .FirstOrDefault();
            if(checkMiniContentId == null)
            {
                throw new Exception("This Mini Content is not existed");
            } 
            checkMiniContentId.IsDelete = true;
            await _dbContext.SaveChangesAsync();
            return new SOSResponse
            {
                Message = "Delete Sucessful"
            };
        }
    }
}