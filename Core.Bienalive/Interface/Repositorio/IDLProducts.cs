namespace Core.Bienalive.Interface.Repositorio
{
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.Products;

    public interface IDLProducts
    {
        #region Instancias

        /// <summary>Consulta la Products.</summary>
        /// <param name="parametrosBusqueda">Parametros de entrada para la consulta.</param>
        /// <returns>Lista de Products consultadas.</returns>
        Task<IEnumerable<Products>> ConsultarProducts(BusquedaProducts parametrosBusqueda);

        /// <summary>Crea la entidad Products.</summary>
        /// <param name="Products">Parametros de entrada para la creacion.</param>
        /// <returns>Entidad Products.</returns>
        Task<Products> CrearProducts(Products Products);

        /// <summary>Actualiza la Products.</summary>
        /// <param name="Products">Parámetros de entrada para la actualizacion de la Products.</param>
        /// <returns>Entidad Products Actualizada.</returns>
        Task<Products> ActualizarProducts(Products Products);

        /// <summary>Elimina la Products.</summary>
        /// <param name="Id">Parámetro de entrada para la Eliminacion de la Products.</param>
        /// <returns>Entidad Products Eliminada.</returns>
        Task<Products> EliminarProducts(int Id);

        #endregion
    }
}
