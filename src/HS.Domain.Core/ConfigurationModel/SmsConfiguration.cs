using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.ConfigurationModel
{
    public class SmsConfiguration
    {
        public  string UserApikey { get; set; }
        public  string SecretKey { get; set; }
        public string LineNumber { get; set; }
    }
}
