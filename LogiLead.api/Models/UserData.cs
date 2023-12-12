using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LogiLead.api.Models
{
    public class UserData
    {
        public int UserId { get; set; }
        
        [Required]
        [EmailAddress]
        [MaxLength(75)]
        public string Email { get; set; }
        
        [JsonIgnore]
        public string HashedPassword { get; set; }
        
        [JsonIgnore]
        public string Salt { get; set; }
        
        public DateTime PasswordChangeDate { get; set; }
    }
}
