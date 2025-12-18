using Utilitarios.Entidades;

namespace Core.Bienalive.Entidades
{
    public class Schedules : EntidadBase
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Identificador del miembro del equipo asociado al horario.</value>
        public long? TeamMemberId { get; set; }

        /// <value>Fecha del horario.</value>
        public DateOnly ScheduleDate { get; set; }

        /// <value>Hora de inicio del horario.</value>
        public TimeOnly StartTime { get; set; }

        /// <value>Hora de fin del horario.</value>
        public TimeOnly EndTime { get; set; }
    }
}
