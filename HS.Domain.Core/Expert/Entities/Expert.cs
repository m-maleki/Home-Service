using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Expert.Entities
{
    public class Expert
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Biography { get; set; }
        public int Age { get; set; }
        public string? PhoneNumber { get; set; }
        public string? MobileNumber { get; set; }
        public int Score { get; set; }
        public DateTime Birthday { get; set; }
        List<Specialty>? Specialties { get; set; }
        List<Activity>? Activities { get; set; }
    }
}
