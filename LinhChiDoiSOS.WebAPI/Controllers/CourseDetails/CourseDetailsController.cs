using LinhChiDoiSOS.Application.Common.Response;
using LinhChiDoiSOS.Application.Features.CourseDetails.Commands.CreateCourseDetail;
using LinhChiDoiSOS.Application.Features.CourseDetails.Queries;
using LinhChiDoiSOS.Application.Features.CourseDetails.Queries.GetAllCourseDetail;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LinhChiDoiSOS.WebAPI.Controllers.CourseDetails
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseDetailsController : ControllerBase
    {
        private IMediator _mediator;

        public CourseDetailsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("all")]
        public async Task<List<CourseDetailResponse>> Get()
        {
            var response = await _mediator.Send(new GetAllCourseDetailQuery());
            return response;
        }

        [HttpPost]
        [Route("create")]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<SOSResponse> Post(CreateCourseDetailCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }
    }
}
