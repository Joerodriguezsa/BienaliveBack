using Utilitarios.Entidades;

namespace Core.Bienalive.Entidades
{
    public class TeamMembers : EntidadBase
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Foto del miembro del equipo.</value>
        public string? Photo { get; set; }

        /// <value>Identificador del usuario asociado (si aplica).</value>
        public long? UserId { get; set; }

        /// <value>personalExperience.</value>
        public string? PersonalExperience { get; set; }

        /// <value>degree.</value>
        public string? Degree { get; set; }

        /// <value>aboutme.</value>
        public string? AboutMe { get; set; }
    }
}
