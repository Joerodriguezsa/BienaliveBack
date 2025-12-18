namespace Core.Bienalive.EntidadesPersonalizadas.Customers
{
    /// <summary>Inicialización de los parametros de la entidad Customers.</summary>
    public class BusquedaCustomers
    {
        /// <value>Id.</value>
        public long? Id { get; set; }

        /// <value>Name.</value>
        public string? Name { get; set; }

        /// <value>Email.</value>
        public string? Email { get; set; }

        /// <value>Phone.</value>
        public string? Phone { get; set; }

        /// <value>DateOfBirth.</value>
        public DateOnly? DateOfBirth { get; set; }

        /// <value>Gender.</value>
        public string? Gender { get; set; }
    }
}
