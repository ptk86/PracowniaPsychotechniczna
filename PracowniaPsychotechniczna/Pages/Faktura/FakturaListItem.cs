using System.ComponentModel;

namespace PracowniaPsychotechniczna.Pages.Faktura
{
    public class FakturaListItem
    {
        public int Id { get; set; }

        public string NumerFaktury { get; set; }

        [DisplayName("Nazwa Firmy")]
        public string NazwaFirmy { get; set; }

        [DisplayName("Liczba Badań")]
        public int LiczbaBadan { get; set; }

        [DisplayName("Całkowity Koszt [zł]")]
        public int CalkowityKosztBadan { get; set; }
    }
}