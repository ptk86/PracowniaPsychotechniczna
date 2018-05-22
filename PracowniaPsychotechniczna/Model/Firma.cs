using System.Collections.Generic;

namespace PracowniaPsychotechniczna.Model
{
    public class Firma
    {
        public Firma()
        {
            FirmaBadanieList = new List<FirmaBadanie>();
        }
        public int Id { get; set; }
        public string Nazwa { get; set; }
        public string Adres { get; set; }
        public string Nip { get; set; }

        public ICollection<FirmaBadanie> FirmaBadanieList { get; set; }
    }
}