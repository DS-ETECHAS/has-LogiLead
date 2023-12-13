using System.ComponentModel.DataAnnotations;

namespace LogiLead.api.Models
{
    public class DeliveryMan
    {
        [Key]
        public int DeliveryManId { get; set; } // Assuming an ID field

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        [EmailAddress]
        public string Email { get; set; }

        // Navigation property
        public virtual File Avatar { get; set; }
        public int AvatarId { get; set; }
    }
}
