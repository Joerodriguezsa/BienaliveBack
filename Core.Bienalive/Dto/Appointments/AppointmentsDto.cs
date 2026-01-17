namespace Core.Bienalive.Dto.Appointments
{
    public class AppointmentsDto
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Identificador del cliente.</value>
        public long? CustomerId { get; set; }

        /// <value>Identificador del servicio.</value>
        public long? ServiceId { get; set; }

        /// <value>Fecha y hora de la cita.</value>
        public DateTime AppointmentDateStart { get; set; }

        /// <value>Fecha y hora de la cita.</value>
        public DateTime AppointmentDateEnd { get; set; }

        /// <value>Identificador del miembro del equipo.</value>
        public long? TeamMemberId { get; set; }

        /// <value>Identificador del estado de la cita.</value>
        public long? StatusId { get; set; }
    }
}
