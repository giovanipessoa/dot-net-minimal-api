using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinimalAPI.Models
{
    [Table("appointments")]
    public class Appointment
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Customer's name is required")]
        [MaxLength(150, ErrorMessage = "Customer's name cannot exceed 150 characters")]
        [Column("customername")]
        public string CustomerName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Service description is required")]
        [MaxLength(255, ErrorMessage = "Service description cannot exceed 255 characters")]
        [Column("servicedescription")]
        public string ServiceDescription { get; set; } = string.Empty;

        [Required(ErrorMessage = "Scheduled time is required")]
        [DataType(DataType.DateTime)]
        [Column("scheduledtime")]
        public DateTime ScheduledTime { get; set; }

        [Required(ErrorMessage = "Status is required")]
        [MaxLength(50, ErrorMessage = "Status cannot exceed 50 characters")]
        [Column("status")]
        public string Status { get; set; } = "Pending";

        [Required(ErrorMessage = "Created time is required")]
        [Column("createdat")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}