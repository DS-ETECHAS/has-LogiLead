using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace LogiLead.api.Models
{
    public class UserData
    {
        [Key]
        [ForeignKey("User")]
        public int UserId { get; set; }
        
        [Required]
        [EmailAddress]
        [MaxLength(75)]
        [NotNull]
        public string Email { get; set; }
        
        [JsonIgnore]
        public string HashedPassword { get; set; }
        
        public DateTime PasswordChangeDate { get; set; } = DateTime.UtcNow;
        public User User { get; set; }
    }
}
