namespace Core.Bienalive.Dto.Customers
{
    public class CustomersDto
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Nombre del cliente.</value>
        public string Name { get; set; } = string.Empty;

        /// <value>Correo electrónico del cliente.</value>
        public string Email { get; set; } = string.Empty;

        /// <value>Teléfono del cliente.</value>
        public string? Phone { get; set; }

        /// <value>Fecha de nacimiento del cliente.</value>
        public DateOnly? DateOfBirth { get; set; }

        /// <value>Género del cliente.</value>
        public string? Address { get; set; }
    }
}
