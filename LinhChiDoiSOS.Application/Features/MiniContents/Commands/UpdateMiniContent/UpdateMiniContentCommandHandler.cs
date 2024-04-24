using AutoMapper;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Common.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.MiniContents.Commands.UpdateMiniContent
{
    public class UpdateMiniContentCommandHandler : IRequestHandler<UpdateMiniContentCommand, SOSResponse>
    {
        private readonly IMapper _mappper;
        private readonly ILinhChiDoiSOSDbContext _dbContext;

        public UpdateMiniContentCommandHandler(IMapper mappper, ILinhChiDoiSOSDbContext dbContext)
        {
            _mappper = mappper;
            _dbContext = dbContext;
        }

        public async Task<SOSResponse> Handle(UpdateMiniContentCommand request, CancellationToken cancellationToken)
        {
            var miniContent = _dbContext.MiniContent
                .Where(x => x.Id == request.MiniContentId && !x.IsDelete)
                .FirstOrDefault();
            if(miniContent == null)
            {
                throw new Exception("This MiniContent is not existed");
            } 
            if(request.ContentUrl != null)
            {
                miniContent.ContentUrl = request.ContentUrl;
            }
            if(request.Content != null)
            {
                miniContent.Content = request.Content;
            }
            await _dbContext.SaveChangesAsync();
            return new SOSResponse
            {
                Message = "Update Sucessful"
            };
        }
    }
}
