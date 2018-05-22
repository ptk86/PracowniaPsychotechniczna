using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DataBadania { get; set; }
    }
}