using Utilitarios.Entidades;

namespace Core.Bienalive.Entidades
{
    public class Sales : EntidadBase
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Identificador del cliente asociado a la venta.</value>
        public long? CustomerId { get; set; }

        /// <value>Fecha y hora de la venta.</value>
        public DateTime SaleDate { get; set; }
    }
}
