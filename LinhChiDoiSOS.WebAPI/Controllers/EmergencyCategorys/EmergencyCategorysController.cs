using LinhChiDoiSOS.Application.Common.Response;
using LinhChiDoiSOS.Application.Features.Customers.Commands.UpdateCustomer;
using LinhChiDoiSOS.Application.Features.EmergencyCategorys.Commands.CreateEmergencyCategory;
using LinhChiDoiSOS.Application.Features.EmergencyCategorys.Commands.DeleteEmergencyCategory;
using LinhChiDoiSOS.Application.Features.EmergencyCategorys.Commands.UpdateEmergencyCategory;
using LinhChiDoiSOS.Application.Features.EmergencyCategorys.Queries.GetAllEmergencyCategory;
using LinhChiDoiSOS.Application.Models.CRUDModel;
using MediatR;
using Microsoft.AspNetCore.Authorization;
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
        public Task<SOSResponse> Put([FromBody]UpdateEmergencyCategoryCommand request)
        {
            var response = _mediator.Send(request);
            return response;
        }
        [HttpPost]
        public Task<SOSResponse> Create([FromBody]CreateEmergencyCategoryCommand request)
        {
            var response = _mediator.Send(request);
            return response;
        }
        [HttpGet]
        public Task<List<EmergencyCategoryModel>> GetAll()
        {
            return _mediator.Send(new GetAllEmergencyCategoryQuery());
        }
        [HttpDelete]
        public Task<SOSResponse> Delete([FromQuery] DeleteEmergencyCategoryCommand request)
        {
            return _mediator.Send(request);
        }
    }
}
