using MimeKit;
using MailKit.Net.Smtp;
using MailKit.Security;
using HS.Domain.Core.ConfigurationModel;
using Microsoft.Extensions.Options;
using HS.Domain.Core.Contracts.Service;

namespace HS.Domain.Services
{
    public class EmailSender: IEmailSender
    {
        private readonly IOptions<EmailConfiguration> _emailConfiguration;

        public EmailSender(IOptions<EmailConfiguration> emailConfiguration)
        {
            _emailConfiguration = emailConfiguration;
        }

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("SoonService", "info@soonservice.ir"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = message;
            bodyBuilder.TextBody = "لینک فعال سازی";
           
            emailMessage.Body= bodyBuilder.ToMessageBody();
            using (var client = new SmtpClient())
            {
                client.LocalDomain = _emailConfiguration.Value.Domain;
                await client.ConnectAsync(_emailConfiguration.Value.SmtpServer, _emailConfiguration.Value.Port, SecureSocketOptions.None).ConfigureAwait(false);
                client.Authenticate(_emailConfiguration.Value.UserName, _emailConfiguration.Value.Password);
                await client.SendAsync(emailMessage).ConfigureAwait(false);
                await client.DisconnectAsync(true).ConfigureAwait(false);
            }
        }

    }
}
