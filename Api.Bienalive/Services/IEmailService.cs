using Api.Bienalive.Models;

namespace Api.Bienalive.Services
{
    public interface IEmailService
    {
        Task SendContactEmailAsync(ContactEmailRequest request, CancellationToken cancellationToken);

        Task SendAppointmentConfirmationAsync(AppointmentConfirmationRequest request, CancellationToken cancellationToken);
    }
}
