namespace Infrastructure.Bienalive.Datos.Mapeos
{
    using Core.Bienalive.Entidades;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class UsersMap : IEntityTypeConfiguration<Users>
    {
        #region Métodos

        /// <summary>Método para realizar la configuración de la entidad según la BD.</summary>
        /// <param name="builder">Entidad a Configurar.</param>
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.ToTable("users", "dbo");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .HasColumnName("id");

            builder.Property(e => e.Name)
                .HasColumnName("name");

            builder.Property(e => e.Email)
                .HasColumnName("email");

            builder.Property(e => e.Password)
                .HasColumnName("password");

            builder.Property(e => e.RoleId)
                .HasColumnName("roleid");

            builder.Property(e => e.Active)
                .HasColumnName("active");
        }

        #endregion     
    }
}
