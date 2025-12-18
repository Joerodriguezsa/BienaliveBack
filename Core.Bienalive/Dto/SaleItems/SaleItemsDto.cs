namespace Core.Bienalive.Dto.SaleItems
{
    public class SaleItemsDto
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Identificador de la venta.</value>
        public long? SaleId { get; set; }

        /// <value>Identificador del producto.</value>
        public long? ProductId { get; set; }

        /// <value>Cantidad.</value>
        public int Quantity { get; set; }

        /// <value>Precio.</value>
        public decimal Price { get; set; }
    }
}
