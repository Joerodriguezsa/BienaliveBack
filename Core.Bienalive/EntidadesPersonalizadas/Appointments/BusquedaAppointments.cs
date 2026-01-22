namespace Core.Bienalive.EntidadesPersonalizadas.Appointments
{
    /// <summary>Inicialización de los parametros de la entidad Appointments.</summary>
    public class BusquedaAppointments
    {
        /// <value>Id.</value>
        public long? Id { get; set; }

        /// <value>CustomerId.</value>
        public long? CustomerId { get; set; }

        /// <value>ServiceId.</value>
        public long? ServiceId { get; set; }

        /// <value>Fecha y hora de la cita.</value>
        public DateTime? AppointmentDateStart { get; set; }

        /// <value>Fecha y hora de la cita.</value>
        public DateTime? AppointmentDateEnd { get; set; }

        /// <value>Precio para el tiempo.</value>
        public decimal? Price { get; set; }

        /// <value>TeamMemberId.</value>
        public long? TeamMemberId { get; set; }

        /// <value>StatusId.</value>
        public long? StatusId { get; set; }
    }
}
