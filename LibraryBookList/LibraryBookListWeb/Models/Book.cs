using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LibraryBookListWeb.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        [DisplayName("Book Page")]
        [Range(1,2500, ErrorMessage = "Invalid Page Number! The number of pages must be between 1 and 2500.")] //  example
        public int Page { get; set; }
        public DateTime AddedDate { get; set; } = DateTime.Now;

    }
}
