﻿using LinhChiDoiSOS.Application.Common.Base;
using LinhChiDoiSOS.Application.Features.Payments.Merchants.Commands;
using LinhChiDoiSOS.Application.Features.Payments.Merchants.Dtos;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace LinhChiDoiSOS.WebAPI.Controllers.Payments.Merchants
{
    [Route("api/v1/merchant")]
    [ApiController]
    public class MerchantsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MerchantsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        /// <summary>
        /// Get merchants base on criteria
        /// </summary>
        /// <param name="criteria"></param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(BaseResultWithData<List<MerchantDtos>>), 200)]
        [ProducesResponseType(400)]
        public IActionResult Get(string criteria)
        {
            var response = new BaseResultWithData<List<MerchantDtos>>();
            return Ok(response);
        }

        /// <summary>
        /// Get merchants paging
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("with-paging")]
        [ProducesResponseType(typeof(BaseResultWithData<BasePagingData<MerchantDtos>>), 200)]
        public IActionResult GetPaging([FromQuery]BasePagingQuery query)
        {
            var response = new BaseResultWithData<BasePagingData<MerchantDtos>>();
            return Ok(response);
        }

        /// <summary>
        /// Get one merchant by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(typeof(BaseResultWithData<MerchantDtos>), 200)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public IActionResult GetOne([FromRoute] Guid id)
        {
            var response = new BaseResultWithData<MerchantDtos>();
            return Ok(response);
        }

        /// <summary>
        /// Create merchant
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <remarks>
        /// 
        ///     POST /merchants
        ///     {
        ///         "MerchantName" : "Website bán hàng A",
        ///         "MerchantWebLink" : "https://webbanhang.com",
        ///         "MerchantIpnUrl" : "https://webbanhang.com/ipn",
        ///         "MerchantReturnUrl" : "https://webbanhang.com/payment/return"
        ///     }
        /// 
        /// </remarks>
        [HttpPost]
        [ProducesResponseType(typeof(BaseResultWithData<MerchantDtos>), 200)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Create([FromBody] CreateMerchant request)
        {
            var response = new BaseResultWithData<MerchantDtos>();
            response = await _mediator.Send(request);
            return Ok(response);
        }

        /// <summary>
        /// Update merchant
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        [ProducesResponseType(typeof(BaseResult), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Update(Guid id, [FromBody] UpdateMerchant request)
        {
            var response = new BaseResult();
            return Ok(response);
        }

        /// <summary>
        /// Set Active Flag
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}/set-active")]
        [ProducesResponseType(typeof(BaseResult), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult SetActive(Guid id, [FromBody] SetActiveMerchant request)
        {
            var response = new BaseResult();
            return Ok(response);
        }

        /// <summary>
        /// Delete merchant
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("{id}")]
        [ProducesResponseType(typeof(BaseResult), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IActionResult Delete(Guid id)
        {
            var response = new BaseResult();
            return Ok(response);
        }
    }
}
