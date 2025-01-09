using System.ComponentModel.DataAnnotations;

namespace WebAppSylwek.Models
{
    public class Genre
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        public static readonly Genre Action = new Genre { Id = 1, Name = "Action" };
        public static readonly Genre Comedy = new Genre { Id = 2, Name = "Comedy" };
        public static readonly Genre Drama = new Genre { Id = 3, Name = "Drama" };
        public static readonly Genre Horror = new Genre { Id = 4, Name = "Horror" };
        public static readonly Genre SciFi = new Genre { Id = 5, Name = "Sci-Fi" };
    }
}
