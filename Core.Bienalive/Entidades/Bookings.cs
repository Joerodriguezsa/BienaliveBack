using Utilitarios.Entidades;

namespace Core.Bienalive.Entidades
{
    public class Bookings : EntidadBase
    {
        /// <summary>Llave primaria de la entidad.</summary>
        public long Id { get; set; }

        /// <summary>Cliente asociado a la reserva.</summary>
        public long CustomerId { get; set; }

        /// <summary>Empleado (miembro del equipo) asignado a la reserva.</summary>
        public long TeamMemberId { get; set; }

        /// <summary>
        /// Opción seleccionada (servicio + duración + precio) desde ServicesTimePrice.
        /// Esto define la duración de la cita.
        /// </summary>
        public long ServiceTimePriceId { get; set; }

        /// <summary>Fecha y hora de inicio de la reserva.</summary>
        public DateTime StartAt { get; set; }

        /// <summary>Fecha y hora de fin de la reserva.</summary>
        public DateTime EndAt { get; set; }

        /// <summary>Estado de la reserva (CONFIRMED, PENDING, CANCELLED, etc.).</summary>
        public string Status { get; set; } = "CONFIRMED";
    }
}
