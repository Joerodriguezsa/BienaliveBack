namespace Api.Bienalive.Models
{
    public class EmailSendResponse
    {
        public string Message { get; set; } = string.Empty;

        public string? SentTo { get; set; }
    }
}
