using FluentValidation;
using PracowniaPsychotechniczna.Dal;

namespace PracowniaPsychotechniczna.Model
{
    public class FrimaValidatior : AbstractValidator<Firma>
    {
        private readonly ApplicationContext _context;

        public FrimaValidatior(ApplicationContext context)
        {
            _context = context;

            RuleFor(b => b.Nazwa).NotEmpty();
            RuleFor(b => b.Adres).NotEmpty();
            RuleFor(b => b.Nip).NotEmpty();
            RuleFor(b => b.Nip).Matches(@"^\d{10}$");
            RuleFor(b => b.Nip).Must(IsNipChecksumValid).WithMessage("Nieprawidłowy NIP!");
        }

        public bool IsNipChecksumValid(string nip)
        {
            return ValidationHelper.ValidateModuloChecksum(nip, new [] { 6, 5, 7, 2, 3, 4, 5, 6, 7 });
        }
    }
}