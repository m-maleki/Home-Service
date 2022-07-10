using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HS.Domain.Core.Entities
{
    public class HomeService
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImgUrl { get; set; }
        public double Price { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public HomeServiceCategory? HomeServiceCategory { get; set; }
        public bool IsDeleted { get; set; } = false;
        public Order? Orders { get; set; }

    }
}
