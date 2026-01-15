namespace Api.Bienalive.Services;

using Api.Bienalive.Models;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

public class BlobStorageService
{
    private readonly BlobStorageOptions _options;

    public BlobStorageService(IOptions<BlobStorageOptions> options)
    {
        _options = options.Value;
    }

    public async Task<BlobUploadResponse> UploadAsync(
        IFormFile archivo,
        string blobName,
        CancellationToken cancellationToken)
    {
        if (string.IsNullOrWhiteSpace(_options.ConnectionString))
        {
            throw new InvalidOperationException("La cadena de conexión de BlobStorage no está configurada.");
        }

        if (string.IsNullOrWhiteSpace(_options.ContainerName))
        {
            throw new InvalidOperationException("El contenedor de BlobStorage no está configurado.");
        }

        BlobServiceClient blobServiceClient = new BlobServiceClient(_options.ConnectionString);
        BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(_options.ContainerName);
        await containerClient.CreateIfNotExistsAsync(PublicAccessType.Blob, cancellationToken: cancellationToken);

        BlobClient blobClient = containerClient.GetBlobClient(blobName);
        BlobHttpHeaders headers = new BlobHttpHeaders { ContentType = archivo.ContentType };

        await using Stream stream = archivo.OpenReadStream();
        await blobClient.UploadAsync(stream, new BlobUploadOptions { HttpHeaders = headers }, cancellationToken);

        return new BlobUploadResponse
        {
            BlobName = blobName,
            Url = blobClient.Uri.ToString(),
            ContentType = archivo.ContentType ?? string.Empty,
            Size = archivo.Length
        };
    }
}
