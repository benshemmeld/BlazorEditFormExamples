using BlazorEditFormExamples.Model;
using FluentValidation;

namespace BlazorEditFormExamples.Validators
{
    public class FormContactModelValidator : AbstractValidator<FormContactModel>
    {
        public FormContactModelValidator()
        {
            RuleFor(c => c.Contact).NotNull().SetInheritanceValidator(v =>
            {
                v.Add(new ContactPersonValidator());
                v.Add(new ContactOrganisationValidator());
            });
        }
    }
}
