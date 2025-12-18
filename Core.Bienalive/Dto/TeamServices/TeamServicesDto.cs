namespace Core.Bienalive.Dto.TeamServices
{
    public class TeamServicesDto
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Identificador del miembro del equipo.</value>
        public long? TeamMemberId { get; set; }

        /// <value>Identificador del servicio.</value>
        public long? ServiceId { get; set; }
    }
}
