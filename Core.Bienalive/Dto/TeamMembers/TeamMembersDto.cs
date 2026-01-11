using Core.Bienalive.Dto.Users;

namespace Core.Bienalive.Dto.TeamMembers
{
    public class TeamMembersDto
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Photo.</value>
        public string? Photo { get; set; }

        /// <value>Identificador del usuario asociado.</value>
        public long? UserId { get; set; }

        /// Datos de la entidad Users asociada.
        /// <value>Nombre del usuario.</value>
        public string Name { get; set; } = string.Empty;

        /// <value>Correo electrónico del usuario.</value>
        public string Email { get; set; } = string.Empty;

        /// <value>Rol asignado al usuario.</value>
        public long? RoleId { get; set; }
    }
}
