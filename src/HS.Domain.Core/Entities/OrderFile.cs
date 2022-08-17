using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS.Domain.Core.Entities
{
    public class OrderFile
    {
        #region Properties

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public bool IsDeleted { get; set; }
        public int OrderId { get; set; }

        #endregion Properties

        #region Navigation properties

        public virtual Order Order { get; set; } = null!;

        #endregion Navigation properties
    }
}
