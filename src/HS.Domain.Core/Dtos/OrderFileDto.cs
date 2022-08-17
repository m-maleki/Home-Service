using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Dtos
{
    public class OrderFileDto
    {
        #region Properties

        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Name { get; set; } = null!;

        #endregion Properties

    }
}
