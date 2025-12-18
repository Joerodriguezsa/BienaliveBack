namespace Core.Bienalive.EntidadesPersonalizadas.Appointments
{
    /// <summary>Inicialización de los parametros de la entidad Appointments.</summary>
    public class CreacionAppointments
    {
        /// <value>CustomerId.</value>
        public long CustomerId { get; set; }

        /// <value>ServiceId.</value>
        public long ServiceId { get; set; }

        /// <value>AppointmentDate.</value>
        public required DateTime AppointmentDate { get; set; }

        /// <value>TeamMemberId.</value>
        public long TeamMemberId { get; set; }

        /// <value>StatusId.</value>
        public long StatusId { get; set; }
    }
}
