namespace Core.Bienalive.EntidadesPersonalizadas.Invoices
{
    /// <summary>Inicialización de los parametros de la entidad Invoices.</summary>
    public class CreacionInvoices
    {
        /// <value>CustomerId.</value>
        public long CustomerId { get; set; }

        /// <value>TotalAmount.</value>
        public required decimal TotalAmount { get; set; }

        /// <value>DueDate.</value>
        public required DateOnly DueDate { get; set; }

        /// <value>Status.</value>
        public required string Status { get; set; }
    }
}
