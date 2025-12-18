namespace Core.Bienalive.Dto.Refunds
{
    public class RefundsDto
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Identificador del pago asociado al reembolso.</value>
        public long? PaymentId { get; set; }

        /// <value>Monto del reembolso.</value>
        public decimal Amount { get; set; }

        /// <value>Fecha y hora del reembolso.</value>
        public DateTime RefundDate { get; set; }

        /// <value>Estado del reembolso.</value>
        public string Status { get; set; } = string.Empty;
    }
}
