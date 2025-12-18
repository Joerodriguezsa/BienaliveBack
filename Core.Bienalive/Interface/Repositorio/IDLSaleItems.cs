namespace Core.Bienalive.Interface.Repositorio
{
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.SaleItems;

    public interface IDLSaleItems
    {
        #region Instancias

        /// <summary>Consulta la SaleItems.</summary>
        /// <param name="parametrosBusqueda">Parametros de entrada para la consulta.</param>
        /// <returns>Lista de SaleItems consultadas.</returns>
        Task<IEnumerable<SaleItems>> ConsultarSaleItems(BusquedaSaleItems parametrosBusqueda);

        /// <summary>Crea la entidad SaleItems.</summary>
        /// <param name="SaleItems">Parametros de entrada para la creacion.</param>
        /// <returns>Entidad SaleItems.</returns>
        Task<SaleItems> CrearSaleItems(SaleItems SaleItems);

        /// <summary>Actualiza la SaleItems.</summary>
        /// <param name="SaleItems">Parámetros de entrada para la actualizacion de la SaleItems.</param>
        /// <returns>Entidad SaleItems Actualizada.</returns>
        Task<SaleItems> ActualizarSaleItems(SaleItems SaleItems);

        /// <summary>Elimina la SaleItems.</summary>
        /// <param name="Id">Parámetro de entrada para la Eliminacion de la SaleItems.</param>
        /// <returns>Entidad SaleItems Eliminada.</returns>
        Task<SaleItems> EliminarSaleItems(int Id);

        #endregion
    }
}
