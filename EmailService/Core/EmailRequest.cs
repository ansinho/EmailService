namespace EmailService.Core
{
    public record EmailRequest(string To, string Subject, string Body)
    {
    }
}
