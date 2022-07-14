﻿namespace HS.Domain.Core.Entities
{
    public class HomeServiceCategory
    {
        #region Properties
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        #endregion Properties
        #region Navigation properties
        public List<HomeService>? HomeServices { get; set; }
        #endregion Navigation properties
    }

}
