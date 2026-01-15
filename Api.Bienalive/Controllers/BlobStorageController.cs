namespace Api.Bienalive.Controllers;

using Api.Bienalive.Models;
using Api.Bienalive.Services;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class BlobStorageController : ControllerBase
{
    private readonly BlobStorageService _blobStorageService;

    public BlobStorageController(BlobStorageService blobStorageService)
    {
        _blobStorageService = blobStorageService;
    }

    /// <summary>Endpoint para subir archivos a Blob Storage.</summary>
    /// <param name="request">Archivo y datos de ruta.</param>
    /// <param name="cancellationToken">Token de cancelación.</param>
    /// <returns>Información del archivo almacenado.</returns>
    [HttpPost]
    [Route("SubirArchivo")]
    public async Task<ActionResult<BlobUploadResponse>> SubirArchivo(
        [FromForm] BlobUploadRequest request,
        CancellationToken cancellationToken)
    {
        if (request.Archivo == null || request.Archivo.Length == 0)
        {
            return BadRequest("El archivo es requerido.");
        }

        string originalFileName = Path.GetFileName(request.Archivo.FileName);
        string requestedFileName = string.IsNullOrWhiteSpace(request.NombreArchivo)
            ? originalFileName
            : Path.GetFileName(request.NombreArchivo);
        string originalExtension = Path.GetExtension(originalFileName);

        if (string.IsNullOrWhiteSpace(requestedFileName))
        {
            requestedFileName = $"{Guid.NewGuid():N}{originalExtension}";
        }
        else if (string.IsNullOrWhiteSpace(Path.GetExtension(requestedFileName))
            && !string.IsNullOrWhiteSpace(originalExtension))
        {
            requestedFileName = $"{requestedFileName}{originalExtension}";
        }

        string carpeta = request.Carpeta?.Trim().Trim('/');
        string blobName = string.IsNullOrWhiteSpace(carpeta)
            ? requestedFileName
            : $"{carpeta}/{requestedFileName}";

        BlobUploadResponse response = await _blobStorageService.UploadAsync(
            request.Archivo,
            blobName,
            cancellationToken);

        return Ok(response);
    }
}
