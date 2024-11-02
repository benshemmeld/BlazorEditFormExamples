using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace BlazorEditFormExamples.Components
{
    public class EditFormWatcher : ComponentBase
    {
        private EditContext? editContext;

        [CascadingParameter]
        protected EditContext? EditContext
        {
            get => editContext;
            set
            {
                if (editContext != value)
                {
                    editContext = value;
                    if (EditContext != null)
                    {
                        EditContext.OnFieldChanged += async (sender, e) =>
                        {
                            var isValid = IsFormValid();
                            SetIsValid(isValid);
                            await FieldChanged.InvokeAsync(e);
                        };
                    }
                }
            }
        }

        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                var isFormValid = IsFormValid();
                SetIsValid(isFormValid);
            }
        }

        public void ValidateNow()
        {
            var isValid = IsFormValid();
            SetIsValid(isValid);
        }

        [Parameter]
        public EventCallback<FieldChangedEventArgs> FieldChanged { get; set; }

        [Parameter]
        public bool IsValid { get; set; }

        [Parameter]
        public EventCallback<bool> IsValidChanged { get; set; }

        private void SetIsValid(bool value)
        {
            if (value != IsValid)
            {
                IsValid = value;
                IsValidChanged.InvokeAsync(IsValid);
            }
        }

        private bool IsFormValid()
        {
            var validationContext = new ValidationContext(EditContext.Model);
            var validationResults = new List<ValidationResult>();

            return Validator.TryValidateObject(EditContext.Model, validationContext, validationResults, validateAllProperties: true);
        }
    }
}
