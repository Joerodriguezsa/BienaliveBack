namespace Core.Bienalive.EntidadesPersonalizadas.Payments
{
    /// <summary>Inicialización de los parametros de la entidad Payments.</summary>
    public class CreacionPayments
    {
        /// <value>CustomerId.</value>
        public long CustomerId { get; set; }

        /// <value>Amount.</value>
        public required decimal Amount { get; set; }

        /// <value>Currency.</value>
        public required string Currency { get; set; }

        /// <value>Status.</value>
        public required string Status { get; set; }

        /// <value>PaymentDate.</value>
        public required DateTime PaymentDate { get; set; }

        /// <value>TransactionId.</value>
        public required string TransactionId { get; set; }

        /// <value>Method.</value>
        public required string Method { get; set; }
    }
}
