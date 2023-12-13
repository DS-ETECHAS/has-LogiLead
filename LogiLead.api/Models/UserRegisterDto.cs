using System.ComponentModel.DataAnnotations;

namespace LogiLead.api.Models
{
    public class UserRegisterDto
    {
        public string Name { get; set; }
        public string Password { get; set; }
        [Required]
        [EmailAddress]
        [MaxLength(75)]
        public string Email { get; set; }
    }
}
