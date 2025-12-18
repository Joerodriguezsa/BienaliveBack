namespace Core.Bienalive.EntidadesPersonalizadas.SaleItems
{
    /// <summary>Inicialización de los parametros de la entidad SaleItems.</summary>
    public class ActualizacionSaleItems
    {
        /// <value>Id.</value>
        public required long Id { get; set; }

        /// <value>SaleId.</value>
        public long SaleId { get; set; }

        /// <value>ProductId.</value>
        public long ProductId { get; set; }

        /// <value>Quantity.</value>
        public required int Quantity { get; set; }

        /// <value>Price.</value>
        public required decimal Price { get; set; }
    }
}
