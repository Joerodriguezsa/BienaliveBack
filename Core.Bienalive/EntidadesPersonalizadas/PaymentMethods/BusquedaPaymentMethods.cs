namespace Core.Bienalive.EntidadesPersonalizadas.PaymentMethods
{
    /// <summary>Inicialización de los parametros de la entidad PaymentMethods.</summary>
    public class BusquedaPaymentMethods
    {
        /// <value>Id.</value>
        public long? Id { get; set; }

        /// <value>CustomerId.</value>
        public long? CustomerId { get; set; }

        /// <value>Type.</value>
        public string? Type { get; set; }

        /// <value>LastFour.</value>
        public string? LastFour { get; set; }

        /// <value>ExpiryDate.</value>
        public DateOnly? ExpiryDate { get; set; }
    }
}
