using System.ComponentModel.DataAnnotations;

namespace PracowniaPsychotechniczna.Model
{
    public class TypBadania
    {
        public int Id { get; set; }

        [Required]
        public string Nazwa { get; set; }

        [Required]
        public decimal Cena { get; set; }
    }
}