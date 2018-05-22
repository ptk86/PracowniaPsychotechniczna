using System;

namespace PracowniaPsychotechniczna.Pages.Badanie
{
    public class BadanieIndexListItem
    {
        public int Id { get; set; }
        public string TypBadania { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Frima { get; set; }
        public bool CzyPlatnoscWlasna { get; set; }
        public DateTime DataBadania { get; set; }
    }
}