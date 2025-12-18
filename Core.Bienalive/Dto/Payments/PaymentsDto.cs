namespace Core.Bienalive.Dto.Payments
{
    public class PaymentsDto
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Identificador del cliente.</value>
        public long? CustomerId { get; set; }

        /// <value>Monto del pago.</value>
        public decimal Amount { get; set; }

        /// <value>Moneda del pago.</value>
        public string Currency { get; set; } = string.Empty;

        /// <value>Estado del pago.</value>
        public string Status { get; set; } = string.Empty;

        /// <value>Fecha del pago.</value>
        public DateTime PaymentDate { get; set; }

        /// <value>Identificador de la transacción.</value>
        public string TransactionId { get; set; } = string.Empty;

        /// <value>Método de pago.</value>
        public string Method { get; set; } = string.Empty;
    }
}
