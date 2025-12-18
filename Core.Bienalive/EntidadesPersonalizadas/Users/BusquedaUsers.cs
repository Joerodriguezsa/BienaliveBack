namespace Core.Bienalive.EntidadesPersonalizadas.Users
{
    /// <summary>Inicialización de los parametros de la entidad Users.</summary>
    public class BusquedaUsers
    {
        /// <value>Id.</value>
        public long? Id { get; set; }

        /// <value>Name.</value>
        public string? Name { get; set; }

        /// <value>Email.</value>
        public string? Email { get; set; }

        /// <value>Username.</value>
        public string? Username { get; set; }

        /// <value>RoleId.</value>
        public long? RoleId { get; set; }

        /// <value>Active.</value>
        public bool? Active { get; set; }
    }
}
