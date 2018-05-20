using FluentValidation;
using PracowniaPsychotechniczna.Model;

namespace PracowniaPsychotechniczna.Validator
{
    public class TypBadaniaValidator : AbstractValidator<TypBadania>
    {
        public TypBadaniaValidator()
        {
            RuleFor(tb => tb.Nazwa).NotEmpty();
            RuleFor(tb => tb.Cena).NotEmpty();
            RuleFor(tb => tb.Cena).InclusiveBetween(0, 10000);
        }
    }
}