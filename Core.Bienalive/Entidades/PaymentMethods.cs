using Utilitarios.Entidades;

namespace Core.Bienalive.Entidades
{
    public class PaymentMethods : EntidadBase
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Identificador del cliente dueño del método de pago.</value>
        public long? CustomerId { get; set; }

        /// <value>Tipo de método de pago.</value>
        public string Type { get; set; } = string.Empty;

        /// <value>Últimos 4 dígitos del instrumento de pago.</value>
        public string LastFour { get; set; } = string.Empty;

        /// <value>Fecha de expiración del método de pago.</value>
        public DateOnly ExpiryDate { get; set; }
    }
}
