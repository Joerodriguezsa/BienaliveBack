using Utilitarios.Entidades;

namespace Core.Bienalive.Entidades
{
    public class Products : EntidadBase
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Nombre del producto.</value>
        public string Name { get; set; } = string.Empty;

        /// <value>Descripción del producto.</value>
        public string? Description { get; set; }

        /// <value>Precio del producto.</value>
        public decimal Price { get; set; }

        /// <value>Cantidad en inventario.</value>
        public int Stock { get; set; }

        /// <value>Indica si el producto está activo.</value>
        public bool? Active { get; set; }
    }
}
