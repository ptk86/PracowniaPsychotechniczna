using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.Data.Edm.Csdl;

namespace PracowniaPsychotechniczna.Model
{
    public class Badany
    {
        public int Id { get; set; }

        [DisplayName("Imię")]
        [Required(ErrorMessage = "Imię jest wymagane!")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Nazwisko jest wymagane!")]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Pesel jest wymagany!")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "PESEL musi być ciągiem 11 cyfr")]
        public string Pesel { get; set; }

        [Required]
        public string Adres { get; set; }


    }

}
