using HS.Domain.Core.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Dtos
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public int CityId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Biography { get; set; }
        public string? PhoneNumber { get; set; }
        public string? ShebaNumber { get; set; }
        public string? CardNumber { get; set; }
        public string? Address { get; set; }
        public int Score { get; set; }
        public string? Roles { get; set; }
        public string? ProfileImgUrl { get; set; }
        public string? ProfileImgUrlCustomer { get; set; }

        public List<string>? Role { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
        public Guid ApplicationUserId { get; set; }
        public IFormFile? ProfileImgFile { get; set; }
        //public List<HomeServiceSubCategory>? HomeServices { get; set; } = new List<HomeServiceSubCategory>();
        public List<HomeService>? HomeServices { get; set; } = new List<HomeService>();
        public List<HomeServiceDto> SelectHomeServices { get; set; }

        public List<int>? HomeServicesIds { get; set; }
        public ICollection<HomeService> HomeServicesUser { get; set; }
        public List<City> Cities { get; set; }
    }
}
