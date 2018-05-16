using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PracowniaPsychotechniczna.Model
{
    public class TypBadania
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nazwa jest wymagana!")]
        public string Nazwa { get; set; }

        [Required(ErrorMessage = "Cena jest wymagana!")]
        [Range(0,1000, ErrorMessage = "Podaj wartość z przedziału <0, 100>!")]
        [DisplayName("Cena [zł]")]
        public int Cena { get; set; }
    }
}