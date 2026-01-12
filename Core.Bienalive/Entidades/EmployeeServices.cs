using Utilitarios.Entidades;

namespace Core.Bienalive.Entidades
{
    public class EmployeeServices : EntidadBase
    {
        /// <summary>
        /// Llave primaria de la entidad.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Identificador del empleado (User con rol empleado).
        /// </summary>
        public long TeamMemberId { get; set; }

        /// <summary>
        /// Identificador del servicio que el empleado puede prestar.
        /// </summary>
        public long ServiceId { get; set; }

        /// <summary>
        /// Indica si el empleado está activo para este servicio.
        /// </summary>
        public bool Active { get; set; } = true;
    }
}
