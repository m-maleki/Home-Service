namespace HS.Domain.Core.Entities
{
    public class City 
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Customer>? Customers { get; set; }
    }
}
