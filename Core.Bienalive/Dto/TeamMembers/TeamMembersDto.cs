namespace Core.Bienalive.Dto.TeamMembers
{
    public class TeamMembersDto
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Nombre del miembro del equipo.</value>
        public string Name { get; set; } = string.Empty;

        /// <value>Correo electrónico.</value>
        public string Email { get; set; } = string.Empty;

        /// <value>Teléfono.</value>
        public string? Phone { get; set; }

        /// <value>Identificador del usuario asociado.</value>
        public long? UserId { get; set; }
    }
}
