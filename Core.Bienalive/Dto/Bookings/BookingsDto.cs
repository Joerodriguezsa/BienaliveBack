namespace Core.Bienalive.Dto.Bookings
{
    public class BookingsDto
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Identificador del cliente.</value>
        public long CustomerId { get; set; }

        /// <value>Identificador del miembro del equipo.</value>
        public long TeamMemberId { get; set; }

        /// <value>Identificador del servicio + duración + precio.</value>
        public long ServiceTimePriceId { get; set; }

        /// <value>Fecha y hora de inicio de la reserva.</value>
        public DateTime StartAt { get; set; }

        /// <value>Fecha y hora de fin de la reserva.</value>
        public DateTime EndAt { get; set; }

        /// <value>Estado de la reserva.</value>
        public string Status { get; set; } = string.Empty;
    }
}
