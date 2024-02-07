using LinhChiDoiSOS.Application.Common.Exceptions;
using LinhChiDoiSOS.Application.Features.Auth.Queries.ResetPassword;
using LinhChiDoiSOS.Domain.IdentityModels;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LinhChiDoiSOS.Application.Features.Payments.PaymentWithSendMail
{
    public class PaymentWithSendMailQuery : IRequest<string>
    {
        public string Email { get; set; }
    }

    public class PaymentWithSendMailQueryHandler : IRequestHandler<PaymentWithSendMailQuery, string>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public PaymentWithSendMailQueryHandler(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<string> Handle(PaymentWithSendMailQuery request, CancellationToken cancellationToken)
        {
            try {
                var user = await _userManager.FindByEmailAsync(request.Email);
                if (user == null)
                    throw new NotFoundException(nameof(ApplicationUser), request.Email);


                await SendEmailAsync(user.Email, "PaymentSuccessfully", $"Please wait for me a minute");
                await SendEmailAsync("nguyenthanhn537@gmail.com", $"Customer email Payment: {user.Email}", $"Please check money and change status");


                return "PaymentSuccessfully. Please wait for me a minute";
            }
            catch (Exception ex) { throw new BadRequestException($"Error at ResetPasswordQueryHandler : {ex}"); }
        }

        private async Task SendEmailAsync(string email, string subject, string body)
        {
            try {
                var message = new MailMessage();
                message.From = new MailAddress("no-reply@gmail.com");
                message.To.Add(new MailAddress(email));
                message.Subject = subject;

                message.Body = body;
                var smtp = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("nguyenthanhn537@gmail.com", "fekhdfsvjwvetkmq"),
                    EnableSsl = true
                };
                await smtp.SendMailAsync(message);
            }
            catch (Exception ex) { throw new BadRequestException($"Error at SendEmailAsync: {ex}"); }
        }
    }
}
