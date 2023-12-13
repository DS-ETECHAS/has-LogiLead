using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace LogiLead.api.Models
{
    [Table("Recipient")]
    public class Recipient
    {
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Street { get; set; }
        [StringLength(255)]
        public string City { get; set; }
        [StringLength(255)]
        public string ZipCode { get; set; }
        [StringLength(255)]
        public string State { get; set; }
        [StringLength(10)]
        public int Number { get; set; }
        
        [AllowNull]
        [StringLength(255)]
        public string? Complement { get; set; } = null;
    }
}
