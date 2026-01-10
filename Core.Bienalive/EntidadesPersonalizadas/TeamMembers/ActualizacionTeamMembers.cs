namespace Core.Bienalive.EntidadesPersonalizadas.TeamMembers
{
    /// <summary>Inicialización de los parametros de la entidad TeamMembers.</summary>
    public class ActualizacionTeamMembers
    {
        /// <value>Id.</value>
        public required long Id { get; set; }

        /// <value>Photo.</value>
        public string Photo { get; set; }

        /// <value>UserId.</value>
        public long UserId { get; set; }
    }
}
