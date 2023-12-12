using System.ComponentModel.DataAnnotations.Schema;

namespace LogiLead.api.Models
{
    [Table("User")]
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
