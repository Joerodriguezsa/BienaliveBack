using Utilitarios.Entidades;

namespace Core.Bienalive.Entidades
{
    public class TeamMembers : EntidadBase
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Nombre del miembro del equipo.</value>
        public string Name { get; set; } = string.Empty;

        /// <value>Correo electrónico del miembro del equipo.</value>
        public string Email { get; set; } = string.Empty;

        /// <value>Teléfono del miembro del equipo.</value>
        public string? Phone { get; set; }

        /// <value>Identificador del usuario asociado (si aplica).</value>
        public long? UserId { get; set; }
    }
}
