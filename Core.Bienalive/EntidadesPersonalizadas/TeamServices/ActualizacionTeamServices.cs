namespace Core.Bienalive.EntidadesPersonalizadas.TeamServices
{
    /// <summary>Inicialización de los parametros de la entidad TeamServices.</summary>
    public class ActualizacionTeamServices
    {
        /// <value>Id.</value>
        public required long Id { get; set; }

        /// <value>TeamMemberId.</value>
        public long TeamMemberId { get; set; }

        /// <value>ServiceId.</value>
        public long ServiceId { get; set; }
    }
}
