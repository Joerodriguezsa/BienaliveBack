using System.ComponentModel.DataAnnotations;

namespace Api.Bienalive.Models
{
    public class AppointmentConfirmationRequest
    {
        [Required]
        [EmailAddress]
        public string ToEmail { get; set; } = string.Empty;

        [Required]
        public string CustomerName { get; set; } = string.Empty;

        [Required]
        public DateTime AppointmentDate { get; set; }

        public string? ServiceName { get; set; }

        public string? Location { get; set; }

        public string? Notes { get; set; }
    }
}
