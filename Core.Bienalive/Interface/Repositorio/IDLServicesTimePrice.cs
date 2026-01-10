namespace Core.Bienalive.Interface.Repositorio
{
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.ServicesTimePrice;

    public interface IDLServicesTimePrice
    {
        #region Instancias

        /// <summary>Consulta la ServicesTimePrice.</summary>
        /// <param name="parametrosBusqueda">Parametros de entrada para la consulta.</param>
        /// <returns>Lista de ServicesTimePrice consultadas.</returns>
        Task<IEnumerable<ServicesTimePrice>> ConsultarServicesTimePrice(BusquedaServicesTimePrice parametrosBusqueda);

        /// <summary>Crea la entidad ServicesTimePrice.</summary>
        /// <param name="servicesTimePrice">Parametros de entrada para la creacion.</param>
        /// <returns>Entidad ServicesTimePrice.</returns>
        Task<ServicesTimePrice> CrearServicesTimePrice(ServicesTimePrice servicesTimePrice);

        /// <summary>Actualiza la ServicesTimePrice.</summary>
        /// <param name="servicesTimePrice">Parámetros de entrada para la actualizacion de la ServicesTimePrice.</param>
        /// <returns>Entidad ServicesTimePrice Actualizada.</returns>
        Task<ServicesTimePrice> ActualizarServicesTimePrice(ServicesTimePrice servicesTimePrice);

        /// <summary>Elimina la ServicesTimePrice.</summary>
        /// <param name="id">Parámetro de entrada para la Eliminacion de la ServicesTimePrice.</param>
        /// <returns>Entidad ServicesTimePrice Eliminada.</returns>
        Task<ServicesTimePrice> EliminarServicesTimePrice(int id);

        #endregion
    }
}
