using FluentValidation;
using PracowniaPsychotechniczna.Model;

namespace PracowniaPsychotechniczna.Validator
{
    public class PsychologValidatior : AbstractValidator<Psycholog>
    {
        public PsychologValidatior()
        {
            RuleFor(b => b.Imie).NotEmpty();
            RuleFor(b => b.Nazwisko).NotEmpty();
        }
    }
}