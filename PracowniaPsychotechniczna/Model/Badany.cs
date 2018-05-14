using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracowniaPsychotechniczna.Model
{
    public class Badany
    {
        public int Id { get; set; }

        [Required]
        public string Imie { get; set; }

        [Required]
        public string Nazwisko { get; set; }

        [Required]
        public string Pesel { get; set; }

        [Required]
        public string Adres { get; set; }
    }
}
