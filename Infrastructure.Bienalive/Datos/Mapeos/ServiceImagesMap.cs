namespace Infrastructure.Bienalive.Datos.Mapeos
{
    using Core.Bienalive.Entidades;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ServiceImagesMap : IEntityTypeConfiguration<ServiceImages>
    {
        #region Métodos

        /// <summary>Método para realizar la configuración de la entidad según la BD.</summary>
        /// <param name="builder">Entidad a Configurar.</param>
        public void Configure(EntityTypeBuilder<ServiceImages> builder)
        {
            builder.HasKey(e => e.Id)
                .HasName("PK__service___3213E83F1D3F8F71");

            builder.ToTable("ServiceImages", "dbo");
        }

        #endregion     
    }
}
