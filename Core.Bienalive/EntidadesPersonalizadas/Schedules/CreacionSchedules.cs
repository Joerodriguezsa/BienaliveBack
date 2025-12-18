namespace Core.Bienalive.EntidadesPersonalizadas.Schedules
{
    /// <summary>Inicialización de los parametros de la entidad Schedules.</summary>
    public class CreacionSchedules
    {
        /// <value>TeamMemberId.</value>
        public long TeamMemberId { get; set; }

        /// <value>ScheduleDate.</value>
        public required DateOnly ScheduleDate { get; set; }

        /// <value>StartTime.</value>
        public required TimeOnly StartTime { get; set; }

        /// <value>EndTime.</value>
        public required TimeOnly EndTime { get; set; }
    }
}
