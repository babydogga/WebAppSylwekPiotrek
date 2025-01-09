using System.ComponentModel.DataAnnotations;

namespace WebAppSylwek.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Proszę wprowadzić nazwę użytkownika")]
        [StringLength(100)]
        public string Name { get; set; }
        [Display(Name = "Data urodzenia")]
        public DateTime? Birthdate { get; set; }
    }
}
