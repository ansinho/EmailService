namespace EmailService.Core
{
    public interface IEmailSendUseCase
    {
        void SendEmail(string to, string subject, string body);
    }
}

