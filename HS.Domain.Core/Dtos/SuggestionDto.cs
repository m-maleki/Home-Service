using HS.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Dtos
{
    public class SuggestionDto
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ExpertId { get; set; }
        public double SuggestedPrice { get; set; }
        public DateTime DurationOfWork { get; set; }
        public Order? Order { get; set; }
        public Expert? Expert { get; set; }
    }
}
