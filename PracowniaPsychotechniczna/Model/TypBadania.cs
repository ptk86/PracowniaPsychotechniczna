using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PracowniaPsychotechniczna.Model
{
    public class TypBadania
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        [DisplayName("Cena [zł]")]
        public int Cena { get; set; }
    }
}