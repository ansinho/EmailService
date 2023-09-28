using Amazon.Runtime;
using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;
using EmailService.Adapters;
using EmailService.Core.Exceptions;

namespace EmailService.Infra.Ses
{
    public class SesEmailSender : IEmailSenderGatway
    {
        private readonly IAmazonSimpleEmailService _amazonSimpleEmailService;

        
        public SesEmailSender(IAmazonSimpleEmailService amazonSimpleEmailService)
        {
            _amazonSimpleEmailService = amazonSimpleEmailService;
        }

        public void SendEmail(string to, string subject, string body)
        {
            var request = new SendEmailRequest
            {
                Source = "ansin.4k@gmail.com",
                Destination = new Destination
                {
                    ToAddresses = new List<string>
                    {
                        to
                    }
                },
                Message = new Message
                {
                    Subject = new Content(subject),
                    Body = new Body
                    {
                        Text = new Content(body)
                    }
                }
            };

            try
            {
                _amazonSimpleEmailService.SendEmailAsync(request);
            } 
            catch (AmazonServiceException ex) 
            { 
                throw new EmailServiceException("Failure while seding email", ex);
            }
        }
    }
}
