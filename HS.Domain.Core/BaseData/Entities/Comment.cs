using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.BaseData.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Body { get; set; }
        public int Score { get; set; }
        public int ExpertId { get; set; }
    }
}
