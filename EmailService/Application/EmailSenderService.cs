using EmailService.Adapters;
using EmailService.Core;

namespace EmailService.Application
{
    public class EmailSenderService : IEmailSendUseCase
    {
        private readonly IEmailSenderGatway emailSenderGatway;

        public EmailSenderService(IEmailSenderGatway emailGatway)
        { 
            emailSenderGatway = emailGatway;
        }
        public void SendEmail(string to, string subject, string body)
        {
           emailSenderGatway.SendEmail(to, subject, body);
        }
    }
}
