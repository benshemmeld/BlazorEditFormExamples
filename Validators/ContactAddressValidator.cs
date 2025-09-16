using BlazorEditFormExamples.Model;
using FluentValidation;

namespace BlazorEditFormExamples.Validators
{
    public class ContactAddressValidator : AbstractValidator<Address>
    {
        public ContactAddressValidator()
        {
            RuleFor(a => a.Street).NotEmpty();
            RuleFor(a => a.Suburb).NotEmpty();
            RuleFor(a => a.State).NotNull();
            RuleFor(a => a.Postcode)
                .NotEmpty()
                .Matches(@"^\d{4}$")
                .WithMessage("Invalid postcode!");
        }
    }
}
