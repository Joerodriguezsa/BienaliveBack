namespace Core.Bienalive.EntidadesPersonalizadas.EmployeeServices
{
    /// <summary>Inicialización de los parametros de la entidad EmployeeServices.</summary>
    public class ActualizacionEmployeeServices
    {
        /// <value>Id.</value>
        public required long Id { get; set; }

        /// <value>TeamMemberId.</value>
        public long TeamMemberId { get; set; }

        /// <value>ServiceId.</value>
        public long ServiceId { get; set; }

        /// <value>Active.</value>
        public bool Active { get; set; }
    }
}
