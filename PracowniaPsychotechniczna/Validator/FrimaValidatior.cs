using System.Linq;
using FluentValidation;
using PracowniaPsychotechniczna.Dal;
using PracowniaPsychotechniczna.Model;

namespace PracowniaPsychotechniczna.Validator
{
    public class FrimaValidatior : AbstractValidator<Firma>
    {
        private readonly ApplicationContext _context;

        public FrimaValidatior(ApplicationContext context)
        {
            _context = context;

            RuleFor(f => f.Nazwa).NotEmpty();
            RuleFor(f => f.Adres).NotEmpty();
            RuleFor(f => f.Nip).NotEmpty();
            RuleFor(f => f.Nip).Matches(@"^\d{10}$");
            RuleFor(f => f.Nip).Must(IsNipChecksumValid).WithMessage("Nieprawidłowy NIP!");
            RuleFor(f => f.Nip).Must((f, n) => IsUnique(n, f.Id)).WithMessage("Ten NIP został już zarejestrowany!");
        }

        public bool IsNipChecksumValid(string nip)
        {
            return ValidationHelper.ValidateModuloChecksum(nip, new [] { 6, 5, 7, 2, 3, 4, 5, 6, 7 }, 11);
        }

        public bool IsUnique(string nip, int id)
        {
            return _context.Firma
                .Where(b => b.Id != id)
                .All(b => b.Nip != nip);
        }
    }
}