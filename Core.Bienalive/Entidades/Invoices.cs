using Utilitarios.Entidades;

namespace Core.Bienalive.Entidades
{
    public class Invoices : EntidadBase
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Identificador del cliente asociado a la factura.</value>
        public long? CustomerId { get; set; }

        /// <value>Valor total de la factura.</value>
        public decimal TotalAmount { get; set; }

        /// <value>Fecha de vencimiento de la factura.</value>
        public DateOnly DueDate { get; set; }

        /// <value>Estado de la factura.</value>
        public string Status { get; set; } = string.Empty;
    }
}
