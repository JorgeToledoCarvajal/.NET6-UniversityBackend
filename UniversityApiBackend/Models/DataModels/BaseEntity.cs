using System.ComponentModel.DataAnnotations;

namespace UniversityApiBackend.Models.DataModels
{
    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string UpdateBy { get; set; } = string.Empty;
        public DateTime? UpdateAt { get; set; }
        public string DeletedBy { get; set; } = string.Empty;
        public DateTime? DeletedAT { get; set; }
        public bool IsDeleted { get; set; } = false;


    }
}
