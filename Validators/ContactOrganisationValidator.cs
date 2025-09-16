using BlazorEditFormExamples.Model;
using FluentValidation;

namespace BlazorEditFormExamples.Validators
{
    public class ContactOrganisationValidator : AbstractValidator<ContactOrganisation>
    {
        public ContactOrganisationValidator()
        {
            Include(new ContactBaseValidator());
            RuleFor(c => c.KeyContact).NotEmpty();
        }
    }
}
