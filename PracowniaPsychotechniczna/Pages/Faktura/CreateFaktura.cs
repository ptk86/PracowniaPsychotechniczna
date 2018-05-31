using System;
using System.Collections.Generic;
using System.Linq;
using LiczbyNaSlowaNETCore;
using LiczbyNaSlowaNETCore.Dictionaries;

namespace PracowniaPsychotechniczna.Pages.Faktura
{
    public class CreateFaktura
    {
        public CreateFaktura()
        {
            Badania = new List<Badanie>();
        }
        public Firma Sprzedawca { get; set; }
        public Firma Nabywca { get; set; }
        public DateTime DateTime { get; set; }
        public List<Badanie> Badania { get; set; }

        public int Suma => Badania.Sum(b => b.Cena);
        public DateTime TerminZaplaty => DateTime.Today + TimeSpan.FromDays(14);
        public string SumeSlownie => NumberToText.Convert(Suma, new NumberToTextOptions
        {
            Dictionary = new PolishDictionary(),
            Stems = false,
            Currency = Currency.PLN,
        });
    }

    public class Firma
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string Adres { get; set; }
        public string Nip { get; set; }
    }

    public class Badanie
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Typ { get; set; }
        public int Cena { get; set; }
    }
}