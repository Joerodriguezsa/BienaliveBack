namespace Api.Bienalive.Services
{
    public class EmailOptions
    {
        public const string SectionName = "Email";

        public string Host { get; set; } = string.Empty;

        public int Port { get; set; } = 587;

        public bool EnableSsl { get; set; } = true;

        public string? UserName { get; set; }

        public string? Password { get; set; }

        public string FromEmail { get; set; } = string.Empty;

        public string FromName { get; set; } = "Bienalive";

        public string ContactRecipientEmail { get; set; } = string.Empty;
    }
}
