using EmailSenderAPI.Helpers;

namespace EmailSenderAPI.Services
{
    public interface IEmailService
    {
        Task SendEmailAsync(MailRequest emailRequest);
    }
}
