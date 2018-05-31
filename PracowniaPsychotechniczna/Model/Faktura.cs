using System;
using System.Collections.Generic;

namespace PracowniaPsychotechniczna.Model
{
    public class Faktura
    {
        public Faktura()
        {
            FakturaBadanieList = new List<FakturaBadanie>();
        }

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public ICollection<FakturaBadanie> FakturaBadanieList { get; set; }
    }
}