using System.ComponentModel.DataAnnotations;

namespace WorldStart.ViewModels
{
    public class ContactViewModel
    {

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(4069, MinimumLength = 6)]
        public string Message { get; set; }
    }
}
