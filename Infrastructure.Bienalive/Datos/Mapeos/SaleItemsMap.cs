namespace Infrastructure.Bienalive.Datos.Mapeos
{
    using Core.Bienalive.Entidades;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class SaleItemsMap : IEntityTypeConfiguration<SaleItems>
    {
        #region Métodos

        /// <summary>Método para realizar la configuración de la entidad según la BD.</summary>
        /// <param name="builder">Entidad a Configurar.</param>
        public void Configure(EntityTypeBuilder<SaleItems> builder)
        {
            builder.HasKey(e => e.Id);

            builder.ToTable("saleitems", "dbo");
        }

        #endregion     
    }
}
