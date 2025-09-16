using BlazorEditFormExamples.Model;
using FluentValidation;

namespace BlazorEditFormExamples.Validators
{
    public class ContactPersonValidator : AbstractValidator<ContactPerson>
    {
        public ContactPersonValidator()
        {
            Include(new ContactBaseValidator());
            RuleFor(c => c.Pronoun).NotEmpty();
        }
    }
}
