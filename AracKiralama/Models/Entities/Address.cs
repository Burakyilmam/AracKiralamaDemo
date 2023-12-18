namespace AracKiralama.Models.Entities
{
    public class Address : Base
    {
        public string Title { get; set; }
        public string AddressText { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
