namespace Core.Bienalive.EntidadesPersonalizadas.Products
{
    /// <summary>Inicialización de los parametros de la entidad Products.</summary>
    public class BusquedaProducts
    {
        /// <value>Id.</value>
        public long? Id { get; set; }

        /// <value>Name.</value>
        public string? Name { get; set; }

        /// <value>Description.</value>
        public string? Description { get; set; }

        /// <value>Price.</value>
        public decimal? Price { get; set; }

        /// <value>Stock.</value>
        public int? Stock { get; set; }

        /// <value>Active.</value>
        public bool? Active { get; set; }
    }
}
