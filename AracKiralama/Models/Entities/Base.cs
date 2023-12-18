using System.ComponentModel.DataAnnotations;

namespace AracKiralama.Models.Entities
{
    public class Base
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Statu { get; set; }
    }
}
