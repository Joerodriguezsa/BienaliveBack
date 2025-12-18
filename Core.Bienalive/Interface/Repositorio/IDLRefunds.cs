namespace Core.Bienalive.Interface.Repositorio
{
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.Refunds;

    public interface IDLRefunds
    {
        #region Instancias

        Task<IEnumerable<Refunds>> ConsultarRefunds(BusquedaRefunds parametrosBusqueda);

        Task<Refunds> CrearRefunds(Refunds entidad);

        Task<Refunds> ActualizarRefunds(Refunds entidad);

        Task<Refunds> EliminarRefunds(int id);

        #endregion
    }
}