using Utilitarios.Entidades;

namespace Core.Bienalive.Entidades
{
    public class Roles : EntidadBase
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Nombre del rol.</value>
        public string Name { get; set; } = string.Empty;
    }
}
