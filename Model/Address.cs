using System.ComponentModel.DataAnnotations;

namespace BlazorEditFormExamples.Model
{
    public class Address
    {
        [Required]
        public string Street { get; set; } = string.Empty;

        [Required]
        public string Suburb { get; set; } = string.Empty;

        [Required]
        public SelectListItem? State { get; set; }

        [Required]
        [RegularExpression(@"^\d{4}$", ErrorMessage = "Invalid postcode")]
        public string Postcode { get; set; } = string.Empty;
    }
}
