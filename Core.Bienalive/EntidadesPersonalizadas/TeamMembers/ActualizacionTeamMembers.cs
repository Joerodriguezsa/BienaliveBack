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

        /// <value>personalExperience.</value>
        public string? PersonalExperience { get; set; }

        /// <value>degree.</value>
        public string? Degree { get; set; }

        /// <value>aboutme.</value>
        public string? AboutMe { get; set; }
    }
}
