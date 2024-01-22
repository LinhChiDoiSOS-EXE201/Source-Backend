using LinhChiDoiSOS.Application.Common.Exceptions;
using LinhChiDoiSOS.Application.Features.Auth.Queries.ResetPassword;
using LinhChiDoiSOS.Domain.IdentityModels;
using MailKit.Security;
using MediatR;
using Microsoft.AspNetCore.Identity;
using MimeKit.Text;
using MimeKit;
using System.Text;
using System.Net.Mail;
using System.Net;

public class ResetPasswordQueryHandler : IRequestHandler<ResetPasswordQuery, string>
{

    private readonly UserManager<ApplicationUser> _userManager;
    public ResetPasswordQueryHandler(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<string> Handle(ResetPasswordQuery request, CancellationToken cancellationToken)
    {
        try {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null)
                throw new NotFoundException(nameof(ApplicationUser), request.Email);

            var newPassword = GenerateRandomPassword();

            var resetPasswordResult = await _userManager.ResetPasswordAsync(user, await _userManager.GeneratePasswordResetTokenAsync(user), newPassword);
            if (!resetPasswordResult.Succeeded) {
                throw new BadRequestException("Password reset failed.");
            }

            await SendEmailAsync(user.Email, "Reset password", $"Your new password is: {newPassword}");

            return "Password reset successful. Please check your email for the new password.";
        }
        catch (Exception ex) { throw new BadRequestException($"Error at ResetPasswordQueryHandler : {ex}"); }
    }

    private string GenerateRandomPassword()
    {
        try {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            const string specialChars = "!@#$%^&*()";
            var random = new Random();
            var password = new StringBuilder();


            for (int i = 0; i < 10; i++) {
                password.Append(validChars[random.Next(validChars.Length)]);
            }


            password.Append(specialChars[random.Next(specialChars.Length)]);


            for (int i = password.Length - 1; i > 0; i--) {
                int j = random.Next(i + 1);
                char temp = password[i];
                password[i] = password[j];
                password[j] = temp;
            }

            return password.ToString();
        }
        catch (Exception ex) { throw new BadRequestException($"Error at GenerateRandomPassword: {ex}"); }
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


