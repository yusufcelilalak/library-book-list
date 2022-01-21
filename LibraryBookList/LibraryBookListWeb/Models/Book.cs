using System.ComponentModel.DataAnnotations;

namespace LibraryBookListWeb.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        public string Category { get; set; }
        [Required]
        public int Page { get; set; }
        public DateTime AddedDate { get; set; } = DateTime.Now;

    }
}
