using BlazorEditFormExamples.Model;
using FluentValidation;

namespace BlazorEditFormExamples.Validators
{
    public class ContactBaseValidator : AbstractValidator<ContactBase>
    {
        public ContactBaseValidator()
        {
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Email).NotEmpty().EmailAddress();
            RuleFor(c => c.Phone).Length(10).NotEmpty();
            RuleFor(c => c.Address).SetValidator(new ContactAddressValidator()).When(c => c.AreAddressDetailsRequired);
        }
    }
}
