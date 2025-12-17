namespace Core.Bienalive.EntidadesPersonalizadas.ServiceImages
{
    /// <summary>Inicialización de los parametros de la entidad Services.</summary>
    public class ActualizacionServiceImages
	{
        /// <value>Llave primaria de la entidad.</value>
        public required long Id { get; set; }

        /// <value>Nombre del servicio.</value>
        public required long ServiceId { get; set; }

        /// <value>URL de la imagen del servicio.</value>
        public required string ImageUrl { get; set; }

        /// <value>Tipo de imagen del servicio.</value>
        public required int TipoImagenId { get; set; }
    }
}
