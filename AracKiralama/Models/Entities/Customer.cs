namespace AracKiralama.Models.Entities
{
    public class Customer : Base
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
