using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace LogiLead.api.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; } // Assuming an ID field

        [StringLength(255)]
        [NotNull]
        public string Product { get; set; }

        public DateTime? CanceledAt { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        // Calculated property
        public string Status
        {
            get
            {
                if (CanceledAt.HasValue) return "canceled";
                if (StartDate.HasValue && !EndDate.HasValue) return "withdrawal";
                if (StartDate.HasValue && EndDate.HasValue) return "delivered";
                return "pending";
            }
        }

        // Navigation properties
        public virtual Recipient Recipient { get; set; }
        public int RecipientId { get; set; }

        public virtual DeliveryMan DeliveryMan { get; set; }
        public int DeliveryManId { get; set; }

        public virtual File Signature { get; set; }
        public int SignatureId { get; set; }

    }
}
