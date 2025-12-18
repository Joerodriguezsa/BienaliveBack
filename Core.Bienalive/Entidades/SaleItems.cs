using Utilitarios.Entidades;

namespace Core.Bienalive.Entidades
{
    public class SaleItems : EntidadBase
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Identificador de la venta asociada.</value>
        public long? SaleId { get; set; }

        /// <value>Identificador del producto asociado.</value>
        public long? ProductId { get; set; }

        /// <value>Cantidad del producto en la venta.</value>
        public int Quantity { get; set; }

        /// <value>Precio del ítem en la venta.</value>
        public decimal Price { get; set; }
    }
}
