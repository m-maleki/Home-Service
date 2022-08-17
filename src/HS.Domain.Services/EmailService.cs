using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using HS.Domain.Core.ConfigurationModel;
using Microsoft.Extensions.Options;
using HS.Domain.Core.Contracts.Service;
using Microsoft.Extensions.Logging;

namespace HS.Domain.Services
{
    public class EmailService: IEmailService
    {
        private readonly IOptions<EmailConfiguration> _emailConfiguration;
        private readonly ILogger<EmailService> _logger;
        public EmailService(IOptions<EmailConfiguration> emailConfiguration, ILogger<EmailService> logger)
        {
            _emailConfiguration = emailConfiguration;
            _logger = logger;
        }

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("SoonService", "info@soonservice.ir"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = message;
            bodyBuilder.TextBody = subject;


            emailMessage.Body= bodyBuilder.ToMessageBody();
            using (var client = new SmtpClient())
            {
                client.LocalDomain = _emailConfiguration.Value.Domain;
                await client.ConnectAsync(_emailConfiguration.Value.SmtpServer, _emailConfiguration.Value.Port, SecureSocketOptions.None).ConfigureAwait(false);
                try
                {
                    client.Authenticate(_emailConfiguration.Value.UserName, _emailConfiguration.Value.Password);
                }
                catch(Exception ex)
                {
                    _logger.LogWarning("Send email faild with error {error message}", ex);
                }
                await client.SendAsync(emailMessage).ConfigureAwait(false);
                await client.DisconnectAsync(true).ConfigureAwait(false);
            }
        }

    }
}
