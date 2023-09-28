using EmailService.Application;
using EmailService.Core;
using EmailService.Core.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace EmailService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmailSenderController : ControllerBase
    {
        private readonly EmailSenderService emailSenderService;

        public EmailSenderController(EmailSenderService emailService)
        {
            emailSenderService = emailService;
        }

        [HttpPost]
        [Route("/email")]
        public async Task<IActionResult> SendEmail([FromBody] EmailRequest request)
        {
            try
            {
                emailSenderService.SendEmail(request.To, request.Subject, request.Body);
                return await Task.FromResult(Ok("Email sent successfully"));
            }
            catch (EmailServiceException)
            {
                return await Task.FromResult(StatusCode(500, "An error occurred while sending the email"));
            }
        }
    }
}