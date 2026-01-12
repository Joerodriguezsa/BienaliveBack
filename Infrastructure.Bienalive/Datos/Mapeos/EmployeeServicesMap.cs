namespace Infrastructure.Bienalive.Datos.Mapeos
{
    using Core.Bienalive.Entidades;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class EmployeeServicesMap : IEntityTypeConfiguration<EmployeeServices>
    {
        #region Métodos

        /// <summary>Método para realizar la configuración de la entidad según la BD.</summary>
        /// <param name="builder">Entidad a Configurar.</param>
        public void Configure(EntityTypeBuilder<EmployeeServices> builder)
        {
            builder.HasKey(e => e.Id);

            builder.ToTable("employeeservices", "dbo");
        }

        #endregion
    }
}
