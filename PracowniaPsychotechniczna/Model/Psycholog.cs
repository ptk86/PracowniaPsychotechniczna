using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using PracowniaPsychotechniczna.Dal;

namespace PracowniaPsychotechniczna.Model
{
    public class Psycholog
    {
        public int Id { get; set; }
        [DisplayName("Imię")]
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
    }
}