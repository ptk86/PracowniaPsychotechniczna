using System.Linq;
using FluentValidation;
using PracowniaPsychotechniczna.Dal;
using PracowniaPsychotechniczna.Model;

namespace PracowniaPsychotechniczna.Validator
{
    public class BadanyValidatior : AbstractValidator<Badany>
    {
        private readonly ApplicationContext _context;

        public BadanyValidatior(ApplicationContext context)
        {
            _context = context;

            RuleFor(b => b.Imie).NotEmpty();
            RuleFor(b => b.Nazwisko).NotEmpty();
            RuleFor(b => b.Pesel).NotEmpty();
            RuleFor(b => b.Pesel).Matches(@"^\d{11}$");
            RuleFor(b => b.Pesel).Must(IsPeselChecksumValid).WithMessage("Nieprawidłowy PESEL!");
            RuleFor(b => b.Pesel).Must( (b, p) => IsUnique(p, b.Id)).WithMessage("Ten pesel został już zarejestrowany!");
            RuleFor(b => b.Adres).NotEmpty();
        }

        public bool IsPeselChecksumValid(string pesel)
        {
            return ValidationHelper.ValidateModuloChecksum(pesel, new[] { 9, 7, 3, 1, 9, 7, 3, 1, 9, 7 });
        }

        public bool IsUnique(string pesel, int id)
        {
            return _context.Badany
                            .Where(b => b.Id != id)
                            .All(b => b.Pesel != pesel);
        }
    }

}
