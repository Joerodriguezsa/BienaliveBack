namespace Api.Bienalive.Models;

using Microsoft.AspNetCore.Http;

public class BlobUploadRequest
{
    public IFormFile Archivo { get; set; } = default!;

    public string? NombreArchivo { get; set; }

    public string? Carpeta { get; set; }
}
