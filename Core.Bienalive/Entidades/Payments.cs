using Utilitarios.Entidades;

namespace Core.Bienalive.Entidades
{
    public class Payments : EntidadBase
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Identificador del cliente asociado al pago.</value>
        public long? CustomerId { get; set; }

        /// <value>Monto del pago.</value>
        public decimal Amount { get; set; }

        /// <value>Moneda del pago.</value>
        public string Currency { get; set; } = string.Empty;

        /// <value>Estado del pago.</value>
        public string Status { get; set; } = string.Empty;

        /// <value>Fecha y hora en la que se registró el pago.</value>
        public DateTime PaymentDate { get; set; }

        /// <value>Identificador único de la transacción.</value>
        public string TransactionId { get; set; } = string.Empty;

        /// <value>Método usado para el pago (texto).</value>
        public string Method { get; set; } = string.Empty;
    }
}
