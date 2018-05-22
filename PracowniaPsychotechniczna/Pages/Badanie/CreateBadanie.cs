using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracowniaPsychotechniczna.Pages.Badanie
{
    public class CreateBadanie
    {
        public IEnumerable<Model.Psycholog> Psychologowie { get; set; }
        public IEnumerable<Model.TypBadania> TypyBadan { get; set; }
        [DisplayName("Psycholog")]
        public int PsychologId { get; set; }
        [DisplayName("Typ Badania")]
        public int TypBadaniaId { get; set; }
        public int BadanyId { get; set; }
        [DisplayName("Firma")]
        public int FirmaId { get; set; }
    }
}
