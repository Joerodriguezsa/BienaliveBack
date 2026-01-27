using Api.Bienalive.Models;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Api.Bienalive.Services
{
    public class EmailService : IEmailService
    {
        private readonly EmailOptions _options;
        private readonly ILogger<EmailService> _logger;

        public EmailService(IOptions<EmailOptions> options, ILogger<EmailService> logger)
        {
            _options = options.Value;
            _logger = logger;
        }

        public async Task SendContactEmailAsync(ContactEmailRequest request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(_options.ContactRecipientEmail))
            {
                throw new InvalidOperationException("Contact recipient email is not configured.");
            }

            var subject = $"Contacto Bienalive: {request.Subject}";
            var body = new StringBuilder()
                .AppendLine("Se recibió un nuevo mensaje de contacto.")
                .AppendLine()
                .AppendLine($"Nombre: {request.Name}")
                .AppendLine($"Correo: {request.Email}")
                .AppendLine($"Teléfono: {request.Phone ?? "N/A"}")
                .AppendLine()
                .AppendLine("Mensaje:")
                .AppendLine(request.Message)
                .ToString();

            using var message = CreateMessage(_options.ContactRecipientEmail, subject, body, request.Email);
            await SendAsync(message, cancellationToken);
        }

        public async Task SendAppointmentConfirmationAsync(AppointmentConfirmationRequest request, CancellationToken cancellationToken)
        {
            var subject = "Confirmación de cita Bienalive";
            var body = new StringBuilder()
                .AppendLine($"Hola {request.CustomerName},")
                .AppendLine()
                .AppendLine("Tu cita ha sido confirmada con los siguientes detalles:")
                .AppendLine($"Fecha y hora: {request.AppointmentDate:dddd, dd MMMM yyyy HH:mm}")
                .AppendLine($"Servicio: {request.ServiceName ?? "Por confirmar"}")
                .AppendLine($"Lugar: {request.Location ?? "Por confirmar"}")
                .AppendLine()
                .AppendLine(request.Notes ?? "Si necesitas cambios, contáctanos.")
                .ToString();

            using var message = CreateMessage(request.ToEmail, subject, body, null);
            await SendAsync(message, cancellationToken);
        }

        private MailMessage CreateMessage(string toEmail, string subject, string body, string? replyTo)
        {
            var from = new MailAddress(_options.FromEmail, _options.FromName);
            var message = new MailMessage
            {
                From = from,
                Subject = subject,
                Body = body,
                IsBodyHtml = false
            };
            message.To.Add(new MailAddress(toEmail));

            if (!string.IsNullOrWhiteSpace(replyTo))
            {
                message.ReplyToList.Add(new MailAddress(replyTo));
            }

            return message;
        }

        private async Task SendAsync(MailMessage message, CancellationToken cancellationToken)
        {
            using var client = new SmtpClient(_options.Host, _options.Port)
            {
                EnableSsl = _options.EnableSsl
            };

            if (!string.IsNullOrWhiteSpace(_options.UserName))
            {
                client.Credentials = new NetworkCredential(_options.UserName, _options.Password);
                client.UseDefaultCredentials = false;
            }
            else
            {
                client.UseDefaultCredentials = true;
            }

            _logger.LogInformation("Sending email to {Recipient}", message.To.ToString());
            await client.SendMailAsync(message, cancellationToken);
            _logger.LogInformation("Email sent to {Recipient}", message.To.ToString());
        }
    }
}
