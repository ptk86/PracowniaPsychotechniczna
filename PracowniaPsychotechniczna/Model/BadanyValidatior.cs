using System.Collections.Generic;
using System.Linq;
using FluentValidation;
using PracowniaPsychotechniczna.Dal;

namespace PracowniaPsychotechniczna.Model
{
    public class BadanyValidatior : AbstractValidator<Badany>
    {
        private readonly ApplicationContext _context;

        public BadanyValidatior(ApplicationContext context)
        {
            _context = context;

            RuleFor(b => b.Pesel).Must(IsPeselValid).WithMessage("Nieprawidłowy PESEL!");
        }

        public bool IsPeselValid(string pesel)
        {
            return ValidationHelper.ValidateChecksum(pesel, new[] { 9, 7, 3, 1, 9, 7, 3, 1, 9, 7 });
        }
    }

}
