using System.Linq;
using FluentValidation;
using PracowniaPsychotechniczna.Dal;
using PracowniaPsychotechniczna.Pages.Badanie;

namespace PracowniaPsychotechniczna.Validator
{
    public class CreateBadanieValidator : AbstractValidator<CreateBadanie>
    {
        private readonly ApplicationContext _context;

        public CreateBadanieValidator(ApplicationContext context)
        {
            _context = context;

            RuleFor(cb => cb.BadanyId).Must(id => context.Badany.Any(b => b.Id == id))
                .WithMessage("Brak Badanego w bazie danych!");
            RuleFor(cb => cb.FirmaId).Must(id => context.Firma.Any(b => b.Id == id))
                .WithMessage("Brak Firmy w bazie danych!");
        }
        
    }
}