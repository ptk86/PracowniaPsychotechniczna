using System.ComponentModel.DataAnnotations;

namespace PracowniaPsychotechniczna.Model
{
    public class Psycholog
    {
        public int Id { get; set; }

        [Required]
        public string Imie { get; set; }

        [Required]
        public string Nazwisko { get; set; }
    }
}