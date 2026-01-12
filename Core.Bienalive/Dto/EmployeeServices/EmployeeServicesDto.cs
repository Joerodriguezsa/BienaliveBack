namespace Core.Bienalive.Dto.EmployeeServices
{
    public class EmployeeServicesDto
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Identificador del empleado (User con rol empleado).</value>
        public long TeamMemberId { get; set; }

        /// <value>Identificador del servicio que el empleado puede prestar.</value>
        public long ServiceId { get; set; }

        /// <value>Indica si el empleado está activo para este servicio.</value>
        public bool Active { get; set; }
    }
}
