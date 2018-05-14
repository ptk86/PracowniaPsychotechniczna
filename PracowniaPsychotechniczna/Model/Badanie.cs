using System;
using System.ComponentModel.DataAnnotations;

namespace PracowniaPsychotechniczna.Model
{
    public class Badanie
    {
        public int Id { get; set; }

        [Required]
        public Badany Badany { get; set; }

        public Firma FrimaBadanego { get; set; }

        [Required]
        public DateTime DataBadania { get; set; }

        [Required]
        public TypBadania TypBadania { get; set; }

        [Required]
        public Psycholog Psycholog { get; set; }
    }
}