using System.ComponentModel.DataAnnotations;

namespace LogiLead.api.Models
{
    public class DeliveryProblem
    {
        [Key]
        public int DeliveryProblemId { get; set; } // Assuming an ID field

        [StringLength(255)]
        public string Description { get; set; }

        // Navigation property
        public virtual Order Delivery { get; set; }
        public int DeliveryId { get; set; }
    }
}
