using LinhChiDoiSOS.Application.Common.Exceptions;
using LinhChiDoiSOS.Application.Common.Interfaces;
using LinhChiDoiSOS.Application.Features.Auth.Queries.ChangePassword;
using LinhChiDoiSOS.Application.Features.Auth.Queries.ResetPassword;
using LinhChiDoiSOS.Application.Features.Customers.Queries.GetCustomerByEmail;
using LinhChiDoiSOS.Application.Models.Identity;
using LinhChiDoiSOS.Domain.IdentityModels;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using static Duende.IdentityServer.Models.IdentityResources;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LinhChiDoiSOS.WebAPI.Controllers.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<AuthController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IIdentityService _identityService;

        public AuthController(IMediator mediator, 
            ILogger<AuthController> logger, 
            UserManager<ApplicationUser> userManager, 
            IIdentityService identityService)
        {
            _mediator = mediator;
            _logger = logger;
            _userManager = userManager;
            _identityService = identityService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(AuthRequest model)
        {
            string result;
            if (User.Identity.IsAuthenticated) {
                return BadRequest("Bạn đã đăng nhập.");
            }
            var authResponse = new AuthResponse();
            try {
                result = await _identityService.AuthenticateAsync(model.Email, model.Password);
                if (!String.IsNullOrEmpty(result)) {
                    var tempUser = await _userManager.FindByEmailAsync(model.Email);
                    authResponse.Username = tempUser.UserName;
                    authResponse.FullName = tempUser.Fullname;
                    authResponse.Email = model.Email;
                    authResponse.Id = tempUser.Id;
                    var roles = await _userManager.GetRolesAsync(tempUser);
                    authResponse.ListRoles = (List<string>)roles;
                    authResponse.Token = result;
                    
                    return Ok(authResponse);
                }
            }
            catch (Exception ex) {
                return BadRequest(ex.Message);
            }
            return BadRequest("Đăng nhập thất bại");
        }

        [HttpPost]
        [Route("reset-password")]
        public async Task<IActionResult> ResetPassword([FromForm] ResetPasswordQuery request)
        {
            try {
                var result = await _mediator.Send(new ResetPasswordQuery { Email = request.Email });

                return Ok(result);
            }
            catch (Exception ex) {
                throw new BadRequestException("User does not exist.");
            }
        }

        [HttpPost]
        [Route("change-password")]
        public async Task<IActionResult> ChangePassword(ChangePasswordQuery request)
        {
            try {
                var result = await _mediator.Send(new ChangePasswordQuery
                {
                    Email = request.Email ?? "",
                    CurrentPassword = request.CurrentPassword ?? "",
                    NewPassword = request.NewPassword ?? ""
                });

                return Ok(result);
            }
            catch (Exception ex) {
                if (ex is ValidationException) {
                    ValidationException error = (ValidationException)ex;
                    var errorsDiction = new Dictionary<string, string[]>(error.Errors);
                    return BadRequest(errorsDiction);
                }
                return BadRequest(ex.Message);
            }
        }
    }
}
