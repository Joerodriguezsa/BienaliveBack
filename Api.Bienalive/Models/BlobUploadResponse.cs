namespace Api.Bienalive.Models;

public class BlobUploadResponse
{
    public string BlobName { get; set; } = string.Empty;

    public string Url { get; set; } = string.Empty;

    public string ContentType { get; set; } = string.Empty;

    public long Size { get; set; }
}
