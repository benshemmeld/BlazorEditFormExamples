using System.ComponentModel.DataAnnotations;

namespace BlazorEditFormExamples.Model
{
    public class Person
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        [Phone]
        public string Phone { get; set; } = string.Empty;

        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [ValidateComplexType]
        public Address? Address { get; set; } = new();

        [ValidateComplexType]
        public List<Purchase> PurchaseHistory { get; set; } = new();
    }
}
