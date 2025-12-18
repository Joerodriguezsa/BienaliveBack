namespace Core.Bienalive.Dto.Bookings
{
    public class BookingsDto
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Identificador del cliente.</value>
        public long? CustomerId { get; set; }

        /// <value>Identificador del servicio.</value>
        public long? ServiceId { get; set; }

        /// <value>Identificador del miembro del equipo.</value>
        public long? TeamMemberId { get; set; }

        /// <value>Fecha de la reserva.</value>
        public DateTime BookingDate { get; set; }

        /// <value>Estado de la reserva.</value>
        public string? Status { get; set; }
    }
}
