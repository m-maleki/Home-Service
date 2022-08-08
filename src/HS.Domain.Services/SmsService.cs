using HS.Domain.Core.ConfigurationModel;
using HS.Domain.Core.Contracts.Service;
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

        public SmsService(IOptions<SmsConfiguration> smsConfiguration)
        {
            _smsConfiguration = smsConfiguration;
        }


        public void Send(string message , string phoneNumber)
        {
            string userApikey = _smsConfiguration.Value.UserApikey;
            string secretKey = _smsConfiguration.Value.SecretKey;

            var token = new Token().GetToken(userApikey, secretKey);

            if (string.IsNullOrWhiteSpace(token))
                throw new Exception($@"{nameof(token)} is null");

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
                throw new Exception($@"{nameof(messageSendResponseObject)} is null");

            //if (messageSendResponseObject.IsSuccessful)
            //{


            //}
            //else
            //{

            //}

        }

    }
}
