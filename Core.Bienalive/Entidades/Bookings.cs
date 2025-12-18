using Utilitarios.Entidades;

namespace Core.Bienalive.Entidades
{
    public class Bookings : EntidadBase
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Identificador del cliente asociado a la reserva.</value>
        public long? CustomerId { get; set; }

        /// <value>Identificador del servicio asociado a la reserva.</value>
        public long? ServiceId { get; set; }

        /// <value>Identificador del miembro del equipo asignado.</value>
        public long? TeamMemberId { get; set; }

        /// <value>Fecha y hora de creación/programación de la reserva.</value>
        public DateTime BookingDate { get; set; }

        /// <value>Estado textual de la reserva.</value>
        public string? Status { get; set; }
    }
}
