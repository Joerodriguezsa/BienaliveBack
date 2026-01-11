namespace Core.Bienalive.EntidadesPersonalizadas.Customers
{
    /// <summary>Inicialización de los parametros de la entidad Customers.</summary>
    public class CreacionCustomers
    {
        /// <value>Name.</value>
        public required string Name { get; set; }

        /// <value>Email.</value>
        public required string Email { get; set; }

        /// <value>Phone.</value>
        public string Phone { get; set; }

        /// <value>DateOfBirth.</value>
        public DateOnly DateOfBirth { get; set; }

        /// <value>Address.</value>
        public string Address { get; set; }
    }
}
