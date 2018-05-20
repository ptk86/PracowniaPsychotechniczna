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

            RuleFor(b => b.Nip).Must(IsNipValid).WithMessage("Nieprawidłowy PESEL!");
        }

        public bool IsNipValid(string nip)
        {
            return ValidationHelper.ValidateChecksum(nip, new [] { 6, 5, 7, 2, 3, 4, 5, 6, 7 });
        }


    }
}