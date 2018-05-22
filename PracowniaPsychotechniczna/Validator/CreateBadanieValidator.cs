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

            RuleFor(cb => cb.Badany).NotEmpty();
            RuleFor(cb => cb.BadanyId).Must(bid => context.Badany.Any(b => b.Id == bid))
                .WithMessage("Brak Badanego w bazie danych!");
            RuleFor(cb => cb.Frima).NotEmpty().Unless(cb => cb.CzyPlatnoscWlasna);
            RuleFor(cb => cb.FirmaId).Must(fid => context.Firma.Any(f => f.Id == fid))
                .Unless(cb => cb.CzyPlatnoscWlasna || string.IsNullOrEmpty(cb.Frima))
                .WithMessage("Brak firmy w bazie danych!");
        }

    }
}