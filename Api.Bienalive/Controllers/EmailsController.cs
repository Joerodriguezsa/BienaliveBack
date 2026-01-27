using Api.Bienalive.Models;
using Api.Bienalive.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Bienalive.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmailsController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailsController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost("contact")]
        public async Task<ActionResult<EmailSendResponse>> SendContactEmail([FromBody] ContactEmailRequest request, CancellationToken cancellationToken)
        {
            await _emailService.SendContactEmailAsync(request, cancellationToken);

            return Ok(new EmailSendResponse
            {
                Message = "Mensaje de contacto enviado.",
                SentTo = "Contacto Bienalive"
            });
        }

        [HttpPost("appointment-confirmation")]
        public async Task<ActionResult<EmailSendResponse>> SendAppointmentConfirmation([FromBody] AppointmentConfirmationRequest request, CancellationToken cancellationToken)
        {
            await _emailService.SendAppointmentConfirmationAsync(request, cancellationToken);

            return Ok(new EmailSendResponse
            {
                Message = "Confirmación de cita enviada.",
                SentTo = request.ToEmail
            });
        }
    }
}
