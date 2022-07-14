
namespace HS.Domain.Core.Entities
{
    public class SpecialtyCategory
    {
        #region Properties
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool IsDeleted { get; set; } = false;

        #endregion Properties
        #region Navigation properties
        public List<Specialty>? Specialties { get; set; }
        #endregion Navigation properties
    }
}
