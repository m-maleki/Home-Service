using HS.Domain.Core.ConfigurationModel;
using HS.Domain.Core.Contracts.Service;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SmsIrRestfulNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Services
{
    public class SmsService :ISmsService
    {
        private readonly IOptions<SmsConfiguration> _smsConfiguration;
        private readonly ILogger<SmsService> _loger;
        public SmsService(IOptions<SmsConfiguration> smsConfiguration, ILogger<SmsService> loger)
        {
            _smsConfiguration = smsConfiguration;
            _loger = loger;
        }


        public async Task Send(string message , string phoneNumber)
        {
            string userApikey = _smsConfiguration.Value.UserApikey;
            string secretKey = _smsConfiguration.Value.SecretKey;

            var token = new Token().GetToken(userApikey, secretKey);

            if (string.IsNullOrWhiteSpace(token))
                _loger.LogWarning($"sms api key in null. please chack configuration");

            var messageSendObject = new MessageSendObject()
            {
                Messages = new List<string> { message }.ToArray(),
                MobileNumbers = new List<string> { phoneNumber }.ToArray(),
                LineNumber = _smsConfiguration.Value.LineNumber,
                SendDateTime = null,
                CanContinueInCaseOfError = true
            };

            MessageSendResponseObject messageSendResponseObject = new MessageSend().Send(token, messageSendObject);

            if (messageSendResponseObject == null)
                _loger.LogInformation($"messageSendResponseObject sms in null");

            if (messageSendResponseObject.IsSuccessful)
            {
                _loger.LogInformation($"send sms to number {phoneNumber} width message {message} ");

            }
            else
            {
                _loger.LogInformation($"Error in send sms to number {phoneNumber} width message {message} ");

            }

        }

    }
}
