using Utilitarios.Entidades;

namespace Core.Bienalive.Entidades
{
    public class ServicesTimePrice : EntidadBase
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Identificador del servicio.</value>
        public long ServiceId { get; set; }

        /// <value>Tiempo asociado al servicio.</value>
        public int? Time { get; set; }

        /// <value>Precio para el tiempo.</value>
        public decimal? Price { get; set; }
    }
}
