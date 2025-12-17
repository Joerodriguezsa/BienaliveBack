namespace Infrastructure.Bienalive.Datos.Mapeos
{
    using Core.Bienalive.Entidades;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ServicesMap : IEntityTypeConfiguration<Services>
    {
        #region Métodos

        /// <summary>Método para realizar la configuración de la entidad según la BD.</summary>
        /// <param name="builder">Entidad a Configurar.</param>
        public void Configure(EntityTypeBuilder<Services> builder)
        {
            builder.HasKey(e => e.Id)
                .HasName("PK__services__3213E83FE8447589");

            builder.ToTable("Services", "dbo");
        }

        #endregion     
    }
}
