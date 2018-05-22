using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracowniaPsychotechniczna.Model
{
    public class FirmaBadanie
    {
        public int FirmaId { get; set; }
        public Firma Firma { get; set; }
        public int BadanieId { get; set; }
        public Badanie Badanie { get; set; }
    }
}
