using LinhChiDoiSOS.Application.Common.Response;
using LinhChiDoiSOS.Application.Features.Customers.Commands.UpdateCustomer;
using LinhChiDoiSOS.Application.Features.EmergencyCategorys.Commands.UpdateEmergencyCategory;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LinhChiDoiSOS.WebAPI.Controllers.EmergencyCategorys
{
    [Route("api/v1/emergencycategorys")]
    public class EmergencyCategorysController : ControllerBase
    {
        private IMediator _mediator;

        public EmergencyCategorysController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPut]
        public Task<SOSResponse> Put(UpdateEmergencyCategoryCommand request)
        {
            var response = _mediator.Send(request);
            return response;
        }
    }
}
