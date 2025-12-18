using Utilitarios.Entidades;

namespace Core.Bienalive.Entidades
{
    public class ProductImages : EntidadBase
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Identificador del producto asociado a la imagen.</value>
        public long? ProductId { get; set; }

        /// <value>URL de la imagen del producto.</value>
        public string ImageUrl { get; set; } = string.Empty;
    }
}
