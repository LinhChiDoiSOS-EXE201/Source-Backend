﻿using LinhChiDoiSOS.Application.Common.Response;
using LinhChiDoiSOS.Application.Features.ChuanDoans.Commands.CreateChuanDoan;
using LinhChiDoiSOS.Application.Features.ChuanDoans.Queries;
using LinhChiDoiSOS.Application.Features.ChuanDoans.Queries.GetAllChuanDoan;
using LinhChiDoiSOS.Application.Features.ChuanDoans.Queries.GetListChuanDoanByKeyword;
using LinhChiDoiSOS.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LinhChiDoiSOS.WebAPI.Controllers.ChuanDoans
{
    [Route("api/v1/chuandoan")]
    [ApiController]
    public class ChuanDoansController : ControllerBase
    {
        private IMediator _mediator;

        public ChuanDoansController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("all")]
        public Task<List<ChuanDoanResponse>> Get()
        {
            var response = _mediator.Send(new GetAllChuanDoanQuery());
            return response;
        }

        [HttpGet]
        [Route("by-keyword-id")]
        public Task<List<ChuanDoanByKeywordResponse>> GetKeywordId()
        {
            var response = _mediator.Send(new GetChuanDoanByKeyQuery());
            return response;
        }

        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<SOSResponse> Post([FromBody] CreateChuanDoanCommand request)
        {
            var response = await _mediator.Send(request);
            return response;
        }

    }
}
