using System.ComponentModel.DataAnnotations;

namespace BlazorEditFormExamples.Model
{
    public class Purchase
    {
        [Required]
        public DateTime? Date { get; set; }

        [Required]
        public string Product { get; set; } = string.Empty;

        [Required]
        [Range(0.01, 1000000)]
        public decimal? Price { get; set; }
    }
}
