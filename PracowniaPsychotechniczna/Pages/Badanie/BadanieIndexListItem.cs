using System;
using System.ComponentModel;

namespace PracowniaPsychotechniczna.Pages.Badanie
{
    public class BadanieIndexListItem
    {
        public int Id { get; set; }
        [DisplayName("Typ Badania")]
        public string TypBadania { get; set; }
        [DisplayName("Imię")]
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Frima { get; set; }
        [DisplayName("Data Badania")]
        public DateTime DataBadania { get; set; }
    }
}