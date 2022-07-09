using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Expert.Entities
{
    public class Activity
    {
        public int Id { get; set; }
        public int CoutomerId { get; set; }
        public int HomeServiceId { get; set; }
        public int ExpertId { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public bool IsComplete { get; set; } = false;
        public List<string> ImagesUrl { get; set; }
    }
}
