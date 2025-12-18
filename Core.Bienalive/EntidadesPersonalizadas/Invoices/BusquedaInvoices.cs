namespace Core.Bienalive.EntidadesPersonalizadas.Invoices
{
    /// <summary>Inicialización de los parametros de la entidad Invoices.</summary>
    public class BusquedaInvoices
    {
        /// <value>Id.</value>
        public long? Id { get; set; }

        /// <value>CustomerId.</value>
        public long? CustomerId { get; set; }

        /// <value>TotalAmount.</value>
        public decimal? TotalAmount { get; set; }

        /// <value>DueDate.</value>
        public DateOnly? DueDate { get; set; }

        /// <value>Status.</value>
        public string? Status { get; set; }
    }
}
