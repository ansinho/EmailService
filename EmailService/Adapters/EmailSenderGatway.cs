namespace EmailService.Adapters
{
    public interface IEmailSenderGatway
    {
        void SendEmail(String to, String subject, String body);
    }
}
