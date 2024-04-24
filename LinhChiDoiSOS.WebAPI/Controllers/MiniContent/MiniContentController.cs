using LinhChiDoiSOS.Application.Common.Response;
using LinhChiDoiSOS.Application.Features.MiniContents;
using LinhChiDoiSOS.Application.Features.MiniContents.Commands;
using LinhChiDoiSOS.Application.Features.MiniContents.Commands.DeleteMiniContent;
using LinhChiDoiSOS.Application.Features.MiniContents.Commands.UpdateMiniContent;
using LinhChiDoiSOS.Application.Features.MiniContents.Queries.GetAllMiniContent;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LinhChiDoiSOS.WebAPI.Controllers.MiniContent
{
    [Route("api/v1/minicontent")]
    [ApiController]
    public class MiniContentController : ControllerBase
    {
        private IMediator _mediator;

        public MiniContentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public Task<List<MiniContentResponse>> GetAll() 
        {
            var response = _mediator.Send(new GetAllMiniContentQuery());
            return response;
        }
        [HttpPost]
        public Task<SOSResponse> Create(CreateMiniContentCommand request)
        {
            var response = _mediator.Send(request);
            return response;
        }
        [HttpPut]
        public Task<SOSResponse> Update(UpdateMiniContentCommand request)
        {
            var response = _mediator.Send(request);
            return response;
        }
        [HttpDelete]
        public Task<SOSResponse> Delete(DeleteMiniContentCommand request)
        {
            var response = (_mediator.Send(request));
            return response;
        }
    }
}