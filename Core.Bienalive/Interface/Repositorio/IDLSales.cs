namespace Core.Bienalive.Interface.Repositorio
{
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.Sales;

    public interface IDLSales
    {
        #region Instancias

        /// <summary>Consulta la Sales.</summary>
        /// <param name="parametrosBusqueda">Parametros de entrada para la consulta.</param>
        /// <returns>Lista de Sales consultadas.</returns>
        Task<IEnumerable<Sales>> ConsultarSales(BusquedaSales parametrosBusqueda);

        /// <summary>Crea la entidad Sales.</summary>
        /// <param name="Sales">Parametros de entrada para la creacion.</param>
        /// <returns>Entidad Sales.</returns>
        Task<Sales> CrearSales(Sales Sales);

        /// <summary>Actualiza la Sales.</summary>
        /// <param name="Sales">Parámetros de entrada para la actualizacion de la Sales.</param>
        /// <returns>Entidad Sales Actualizada.</returns>
        Task<Sales> ActualizarSales(Sales Sales);

        /// <summary>Elimina la Sales.</summary>
        /// <param name="Id">Parámetro de entrada para la Eliminacion de la Sales.</param>
        /// <returns>Entidad Sales Eliminada.</returns>
        Task<Sales> EliminarSales(int Id);

        #endregion
    }
}
