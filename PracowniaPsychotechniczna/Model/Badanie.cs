﻿using System;
using System.ComponentModel.DataAnnotations;

namespace PracowniaPsychotechniczna.Model
{
    public class Badanie
    {
        public int Id { get; set; }

        [Required]
        public Badany Badany { get; set; }
        public int BadanyId { get; set; }

        public Firma FrimaBadanego { get; set; }
        public int FrimaBadanegoId { get; set; }

        [Required]
        public DateTime DataBadania { get; set; }

        [Required]
        public TypBadania TypBadania { get; set; }
        public int TypBadaniaId { get; set; }

        [Required]
        public Psycholog Psycholog { get; set; }
        public int PsychologId { get; set; }
    }
}