namespace Core.Bienalive.EntidadesPersonalizadas.Schedules
{
    /// <summary>Inicialización de los parametros de la entidad Schedules.</summary>
    public class BusquedaSchedules
    {
        /// <value>Id.</value>
        public long? Id { get; set; }

        /// <value>TeamMemberId.</value>
        public long? TeamMemberId { get; set; }

        /// <value>ScheduleDate.</value>
        public DateOnly? ScheduleDate { get; set; }

        /// <value>StartTime.</value>
        public TimeOnly? StartTime { get; set; }

        /// <value>EndTime.</value>
        public TimeOnly? EndTime { get; set; }
    }
}
