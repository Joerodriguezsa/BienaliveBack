namespace Core.Bienalive.EntidadesPersonalizadas.AppointmentStatuses
{
    /// <summary>Inicialización de los parametros de la entidad AppointmentStatuses.</summary>
    public class ActualizacionAppointmentStatuses
    {
        /// <value>Llave primaria de la entidad.</value>
        public required long Id { get; set; }

        /// <value>Nombre.</value>
        public required string Name { get; set; } = string.Empty;
    }
}