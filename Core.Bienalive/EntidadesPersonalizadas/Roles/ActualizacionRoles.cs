namespace Core.Bienalive.EntidadesPersonalizadas.Roles
{
    /// <summary>Inicialización de los parametros de la entidad Services.</summary>
    public class ActualizacionRoles
	{
        /// <value>Llave primaria de la entidad.</value>
        public required long Id { get; set; }

        /// <value>Nombre del Rol.</value>
        public required string Name { get; set; } = string.Empty;       
    }
}
