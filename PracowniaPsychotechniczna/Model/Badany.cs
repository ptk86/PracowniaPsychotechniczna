using System.ComponentModel;

namespace PracowniaPsychotechniczna.Model
{
    public class Badany
    {
        public int Id { get; set; }
        [DisplayName("Imię")]
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Pesel { get; set; }
        public string Adres { get; set; }
    }

}
