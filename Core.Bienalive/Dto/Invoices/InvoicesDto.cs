namespace Core.Bienalive.Dto.Invoices
{
    public class InvoicesDto
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Identificador del cliente.</value>
        public long? CustomerId { get; set; }

        /// <value>Total de la factura.</value>
        public decimal TotalAmount { get; set; }

        /// <value>Fecha de vencimiento.</value>
        public DateOnly DueDate { get; set; }

        /// <value>Estado de la factura.</value>
        public string Status { get; set; } = string.Empty;
    }
}
