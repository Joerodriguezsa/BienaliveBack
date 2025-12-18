using Utilitarios.Entidades;

namespace Core.Bienalive.Entidades
{
    public class AppointmentStatuses : EntidadBase
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Nombre del estado de la cita.</value>
        public string Name { get; set; } = string.Empty;
    }
}
