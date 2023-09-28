using Amazon.SimpleEmail;

namespace EmailService.Infra.Ses
{
    public class AwsSesConfig
    {
        private readonly IConfiguration _configuration;

        public AwsSesConfig(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public AmazonSimpleEmailServiceClient GetAmazonSimpleEmailServiceClient()
        {
            var awsOptions = _configuration.GetAWSOptions();
            return (AmazonSimpleEmailServiceClient)awsOptions.CreateServiceClient<IAmazonSimpleEmailService>();
        }
    }
}
