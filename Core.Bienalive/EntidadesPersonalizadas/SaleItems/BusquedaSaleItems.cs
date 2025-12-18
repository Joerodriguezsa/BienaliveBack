namespace Core.Bienalive.EntidadesPersonalizadas.SaleItems
{
    /// <summary>Inicialización de los parametros de la entidad SaleItems.</summary>
    public class BusquedaSaleItems
    {
        /// <value>Id.</value>
        public long? Id { get; set; }

        /// <value>SaleId.</value>
        public long? SaleId { get; set; }

        /// <value>ProductId.</value>
        public long? ProductId { get; set; }

        /// <value>Quantity.</value>
        public int? Quantity { get; set; }

        /// <value>Price.</value>
        public decimal? Price { get; set; }
    }
}
