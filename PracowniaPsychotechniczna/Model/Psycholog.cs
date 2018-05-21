using System.ComponentModel;

namespace PracowniaPsychotechniczna.Model
{
    public class Psycholog
    {
        public int Id { get; set; }
        [DisplayName("Imię")]
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
    }
}