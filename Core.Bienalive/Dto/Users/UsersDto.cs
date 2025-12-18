namespace Core.Bienalive.Dto.Users
{
    public class UsersDto
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Nombre del usuario.</value>
        public string Name { get; set; } = string.Empty;

        /// <value>Correo electrónico del usuario.</value>
        public string Email { get; set; } = string.Empty;

        /// <value>Nombre de usuario.</value>
        public string Username { get; set; } = string.Empty;

        /// <value>Rol asignado al usuario.</value>
        public long? RoleId { get; set; }

        /// <value>Indica si el usuario está activo.</value>
        public bool? Active { get; set; }
    }
}
