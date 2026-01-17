namespace Core.Bienalive.Interface.Repositorio
{
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.AppointmentStatuses;

    public interface IDLAppointmentStatuses
    {
        #region Instancias

        Task<IEnumerable<AppointmentStatuses>> ConsultarAppointmentStatuses(BusquedaAppointmentStatuses parametrosBusqueda);

        Task<AppointmentStatuses> CrearAppointmentStatuses(AppointmentStatuses entidad);

        Task<AppointmentStatuses> ActualizarAppointmentStatuses(AppointmentStatuses entidad);

        Task<AppointmentStatuses> EliminarAppointmentStatuses(long id);

        #endregion
    }
}