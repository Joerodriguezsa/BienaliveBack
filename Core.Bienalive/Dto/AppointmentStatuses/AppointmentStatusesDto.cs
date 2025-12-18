namespace Core.Bienalive.Dto.AppointmentStatuses
{
    public class AppointmentStatusesDto
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Nombre del estado de la cita.</value>
        public string Name { get; set; } = string.Empty;
    }
}
