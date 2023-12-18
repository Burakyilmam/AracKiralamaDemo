namespace AracKiralama.Models.Entities
{
    public class Brand : Base
    {
        public string Name { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
