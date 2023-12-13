using System.ComponentModel.DataAnnotations;

namespace LogiLead.api.Models
{
    public class File
    {
        [Key]
        public int FileId { get; set; } // Assuming an ID field

        [StringLength(255)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Path { get; set; }

        public string Url => $"[BaseUrl]:[Port]/files/{Path}"; // Replace with actual URL generation logic
    }
}
