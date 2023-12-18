namespace AracKiralama.Models.Entities
{
    public class Model : Base
    {
        public string Name { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
