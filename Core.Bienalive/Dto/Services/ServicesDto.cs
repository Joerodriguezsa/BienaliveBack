using Core.Bienalive.Dto.ServiceImages;

namespace Core.Bienalive.Dto.Services
{
    public class ServicesDto 
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Nombre del servicio.</value>
        public string Name { get; set; } = string.Empty;

        /// <value>Descripción corta del servicio.</value>
        public string? ShortDescription { get; set; }

        /// <value>Descripción larga del servicio.</value>
        public string? LongDescription { get; set; }

        /// <value>Tiempo 1 asociado al servicio.</value>
        public int? Time1 { get; set; }

        /// <value>Precio para el tiempo 1.</value>
        public decimal? Price1 { get; set; }

        /// <value>Tiempo 2 asociado al servicio.</value>
        public int? Time2 { get; set; }

        /// <value>Precio para el tiempo 2.</value>
        public decimal? Price2 { get; set; }

        /// <value>Tiempo 3 asociado al servicio.</value>
        public int? Time3 { get; set; }

        /// <value>Precio para el tiempo 3.</value>
        public decimal? Price3 { get; set; }

        /// <value>Tiempo 4 asociado al servicio.</value>
        public int? Time4 { get; set; }

        /// <value>Precio para el tiempo 4.</value>
        public decimal? Price4 { get; set; }

        /// <value>Tiempo 5 asociado al servicio.</value>
        public int? Time5 { get; set; }

        /// <value>Precio para el tiempo 5.</value>
        public decimal? Price5 { get; set; }

        /// <value>Indica si el servicio está activo.</value>
        public bool? Active { get; set; }

        /// <value>Lista de imágenes asociadas al servicio.</value>
        public LinkedList<ServiceImagesDto>? ServiceImages { get; set; }
    }
}
