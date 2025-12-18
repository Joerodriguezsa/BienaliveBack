namespace Infrastructure.Bienalive.Datos.Mapeos
{
    using Core.Bienalive.Entidades;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class AppointmentStatusesMap : IEntityTypeConfiguration<AppointmentStatuses>
    {
        #region Métodos

        /// <summary>Método para realizar la configuración de la entidad según la BD.</summary>
        /// <param name="builder">Entidad a Configurar.</param>
        public void Configure(EntityTypeBuilder<AppointmentStatuses> builder)
        {
            builder.HasKey(e => e.Id);

            builder.ToTable("appointmentstatuses", "dbo");
        }

        #endregion     
    }
}
