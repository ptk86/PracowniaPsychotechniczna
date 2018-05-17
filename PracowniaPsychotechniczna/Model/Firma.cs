using System.ComponentModel.DataAnnotations;

namespace PracowniaPsychotechniczna.Model
{
    public class Firma
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nazwa jest wymagana!")]
        public string Nazwa { get; set; }

        [Required(ErrorMessage = "Adres jest wymagany!")]
        public string Adres { get; set; }

        [Required(ErrorMessage = "NIP jest wymagana!")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "NIP musi być ciągiem 10 cyfr")]
        public string Nip { get; set; }
    }
}