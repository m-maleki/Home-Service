using HS.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Dtos
{
    public class HomeServiceSubCategoryDto
    {
        #region Properties

        public int Id { get; set; }
        public string? Name { get; set; }
        public int HomeServiceCategoryId { get; set; }

        #endregion Properties

        #region Navigation properties

        public HomeServiceCategory? HomeServiceCategory { get; set; }
        public List<HomeService>? HomeServices { get; set; }

        #endregion Navigation properties

    }
}
