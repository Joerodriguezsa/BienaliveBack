namespace Core.Bienalive.Dto.Sales
{
    public class SalesDto
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Identificador del cliente.</value>
        public long? CustomerId { get; set; }

        /// <value>Fecha de la venta.</value>
        public DateTime SaleDate { get; set; }
    }
}
