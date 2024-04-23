using LinhChiDoiSOS.Application.Features.MiniContents;
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
    }
}