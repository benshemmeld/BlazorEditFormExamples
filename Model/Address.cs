using System.ComponentModel.DataAnnotations;

namespace BlazorEditFormExamples.Model
{
    public class Address
    {
        [Required]
        public string Street { get; set; } = string.Empty;

        [Required]
        public string Suburb { get; set; } = string.Empty;

        public SelectListItem? State { get; set; }

        [Required]
        public string Postcode { get; set; } = string.Empty;
    }
}
