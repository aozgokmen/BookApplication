using System.ComponentModel.DataAnnotations;

namespace BookApplication.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string ISBN { get; set; }
    }
}

