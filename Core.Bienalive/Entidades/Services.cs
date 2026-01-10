using Utilitarios.Entidades;

namespace Core.Bienalive.Entidades
{
    public class Services : EntidadBase
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Nombre del servicio.</value>
        public string Name { get; set; } = string.Empty;

        /// <value>Descripción corta del servicio.</value>
        public string? ShortDescription { get; set; }

        /// <value>Descripción larga del servicio.</value>
        public string? LongDescription { get; set; }

        /// <value>Indica si el servicio está activo.</value>
        public bool? Active { get; set; }
    }
}
