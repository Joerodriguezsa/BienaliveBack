namespace Core.Bienalive.Dto.PaymentMethods
{
    public class PaymentMethodsDto
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Identificador del cliente.</value>
        public long? CustomerId { get; set; }

        /// <value>Tipo de método de pago.</value>
        public string Type { get; set; } = string.Empty;

        /// <value>Últimos cuatro dígitos.</value>
        public string LastFour { get; set; } = string.Empty;

        /// <value>Fecha de expiración.</value>
        public DateOnly ExpiryDate { get; set; }
    }
}
