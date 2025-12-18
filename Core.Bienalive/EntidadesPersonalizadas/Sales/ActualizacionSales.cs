namespace Core.Bienalive.EntidadesPersonalizadas.Sales
{
    /// <summary>Inicialización de los parametros de la entidad Sales.</summary>
    public class ActualizacionSales
    {
        /// <value>Id.</value>
        public required long Id { get; set; }

        /// <value>CustomerId.</value>
        public long CustomerId { get; set; }

        /// <value>SaleDate.</value>
        public required DateTime SaleDate { get; set; }
    }
}
