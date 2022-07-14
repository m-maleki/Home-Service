namespace HS.Domain.Core.Entities
{
    public class Specialty
    {
        #region Properties
        public int Id { get; set; }
        public string? Name { get; set; }
        public int SpecialtyCategoryId { get; set; }
        public bool IsDeleted { get; set; } = false;

        #endregion Properties
        #region Navigation properties
        public List<Expert>? Experts { get; set; }
        public SpecialtyCategory? SpecialtyCategory { get; set; }
        #endregion Navigation properties
    }
}