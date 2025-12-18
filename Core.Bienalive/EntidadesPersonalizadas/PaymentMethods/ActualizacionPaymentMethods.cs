namespace Core.Bienalive.EntidadesPersonalizadas.PaymentMethods
{
    /// <summary>Inicialización de los parametros de la entidad PaymentMethods.</summary>
    public class ActualizacionPaymentMethods
    {
        /// <value>Id.</value>
        public required long Id { get; set; }

        /// <value>CustomerId.</value>
        public long CustomerId { get; set; }

        /// <value>Type.</value>
        public required string Type { get; set; }

        /// <value>LastFour.</value>
        public required string LastFour { get; set; }

        /// <value>ExpiryDate.</value>
        public required DateOnly ExpiryDate { get; set; }
    }
}
