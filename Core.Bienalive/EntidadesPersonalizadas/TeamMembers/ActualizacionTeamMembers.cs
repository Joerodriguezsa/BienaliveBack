namespace Core.Bienalive.EntidadesPersonalizadas.TeamMembers
{
    /// <summary>Inicialización de los parametros de la entidad TeamMembers.</summary>
    public class ActualizacionTeamMembers
    {
        /// <value>Id.</value>
        public required long Id { get; set; }

        /// <value>Name.</value>
        public required string Name { get; set; }

        /// <value>Email.</value>
        public required string Email { get; set; }

        /// <value>Phone.</value>
        public string Phone { get; set; }

        /// <value>UserId.</value>
        public long UserId { get; set; }
    }
}
