using Utilitarios.Entidades;

namespace Core.Bienalive.Dto.ServiceImages
{
    public class ServiceImagesDto : EntidadBase
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Nombre del servicio.</value>
        public long ServiceId { get; set; }

        /// <value>URL de la imagen del servicio.</value>
        public string? ImageUrl { get; set; }

        /// <value>Tipo de imagen del servicio.</value>
        public int TipoImagenId { get; set; }
    }
}
