namespace EmailService.Core.Exceptions
{
    public class EmailServiceException : Exception
    {
        public EmailServiceException(string menssage) : base(menssage) {}

        public EmailServiceException(string message, Exception innerException) : base(message, innerException){}

    }

}
