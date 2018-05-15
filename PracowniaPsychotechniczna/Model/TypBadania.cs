using System.ComponentModel.DataAnnotations;

namespace PracowniaPsychotechniczna.Model
{
    public class TypBadania
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nazwa jest wymagana!")]
        public string Nazwa { get; set; }

        [Required(ErrorMessage = "Cena jest wymagana!")]
        public decimal Cena { get; set; }
    }
}