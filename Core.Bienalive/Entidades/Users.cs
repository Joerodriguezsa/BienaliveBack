using Utilitarios.Entidades;

namespace Core.Bienalive.Entidades
{
    public class Users : EntidadBase
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Nombre del usuario.</value>
        public string Name { get; set; } = string.Empty;

        /// <value>Correo electrónico del usuario.</value>
        public string Email { get; set; } = string.Empty;

        /// <value>Contraseña del usuario (hash).</value>
        public string Password { get; set; } = string.Empty;

        /// <value>Rol asignado al usuario.</value>
        public long? RoleId { get; set; }

        /// <value>Nombre de usuario para autenticación.</value>
        public string Username { get; set; } = string.Empty;

        /// <value>Indica si el usuario está activo.</value>
        public bool? Active { get; set; }
    }
}
