namespace Core.Bienalive.Dto.Schedules
{
    public class SchedulesDto
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Identificador del miembro del equipo.</value>
        public long? TeamMemberId { get; set; }

        /// <value>Fecha del horario.</value>
        public DateOnly ScheduleDate { get; set; }

        /// <value>Hora de inicio.</value>
        public TimeOnly StartTime { get; set; }

        /// <value>Hora de fin.</value>
        public TimeOnly EndTime { get; set; }
    }
}
