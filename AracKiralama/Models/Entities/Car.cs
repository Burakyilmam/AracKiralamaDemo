namespace AracKiralama.Models.Entities
{
    public class Car : Base
    {
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public decimal Price { get; set; }
    }
}
