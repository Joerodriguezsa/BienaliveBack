namespace Core.Bienalive.EntidadesPersonalizadas.Payments
{
    /// <summary>Inicialización de los parametros de la entidad Payments.</summary>
    public class BusquedaPayments
    {
        /// <value>Id.</value>
        public long? Id { get; set; }

        /// <value>CustomerId.</value>
        public long? CustomerId { get; set; }

        /// <value>Amount.</value>
        public decimal? Amount { get; set; }

        /// <value>Currency.</value>
        public string? Currency { get; set; }

        /// <value>Status.</value>
        public string? Status { get; set; }

        /// <value>PaymentDate.</value>
        public DateTime? PaymentDate { get; set; }

        /// <value>TransactionId.</value>
        public string? TransactionId { get; set; }

        /// <value>Method.</value>
        public string? Method { get; set; }
    }
}
