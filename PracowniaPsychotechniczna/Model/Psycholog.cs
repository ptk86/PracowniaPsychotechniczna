using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PracowniaPsychotechniczna.Model
{
    public class Psycholog
    {
        public int Id { get; set; }

        [DisplayName("Imię")]
        [Required(ErrorMessage = "Imię jest wymagane!")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Nazwisko jest wymagane!")]
        public string Nazwisko { get; set; }
    }
}