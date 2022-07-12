using HS.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Dtos
{
    public class HomeServiceDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ImgUrl { get; set; }
        public double Price { get; set; }
        public HomeServiceCategory? HomeServiceCategory { get; set; }
        public Order? Orders { get; set; }
    }
}
