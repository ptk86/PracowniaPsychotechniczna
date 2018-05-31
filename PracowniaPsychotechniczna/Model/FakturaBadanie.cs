namespace PracowniaPsychotechniczna.Model
{
    public class FakturaBadanie
    {
        public int FakturaId { get; set; }
        public Faktura Faktura { get; set; }
        public int BadanieId { get; set; }
        public Badanie Badanie { get; set; }
    }
}