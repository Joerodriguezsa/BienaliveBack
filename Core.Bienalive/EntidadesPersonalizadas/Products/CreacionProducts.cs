namespace Core.Bienalive.EntidadesPersonalizadas.Products
{
    /// <summary>Inicialización de los parametros de la entidad Products.</summary>
    public class CreacionProducts
    {
        /// <value>Name.</value>
        public required string Name { get; set; }

        /// <value>Description.</value>
        public string Description { get; set; }

        /// <value>Price.</value>
        public required decimal Price { get; set; }

        /// <value>Stock.</value>
        public required int Stock { get; set; }

        /// <value>Active.</value>
        public bool Active { get; set; }
    }
}
