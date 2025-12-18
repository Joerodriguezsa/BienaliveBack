namespace Core.Bienalive.EntidadesPersonalizadas.Users
{
    /// <summary>Inicialización de los parametros de la entidad Users.</summary>
    public class ActualizacionUsers
    {
        /// <value>Id.</value>
        public required long Id { get; set; }

        /// <value>Name.</value>
        public required string Name { get; set; }

        /// <value>Email.</value>
        public required string Email { get; set; }

        /// <value>Username.</value>
        public required string Username { get; set; }

        /// <value>RoleId.</value>
        public long RoleId { get; set; }

        /// <value>Active.</value>
        public bool Active { get; set; }
    }
}
