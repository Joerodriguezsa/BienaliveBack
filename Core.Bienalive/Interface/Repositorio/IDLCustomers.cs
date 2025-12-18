namespace Core.Bienalive.Interface.Repositorio
{
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.Customers;

    public interface IDLCustomers
    {
        #region Instancias

        /// <summary>Consulta la Customers.</summary>
        /// <param name="parametrosBusqueda">Parametros de entrada para la consulta.</param>
        /// <returns>Lista de Customers consultadas.</returns>
        Task<IEnumerable<Customers>> ConsultarCustomers(BusquedaCustomers parametrosBusqueda);

        /// <summary>Crea la entidad Customers.</summary>
        /// <param name="Customers">Parametros de entrada para la creacion.</param>
        /// <returns>Entidad Customers.</returns>
        Task<Customers> CrearCustomers(Customers Customers);

        /// <summary>Actualiza la Customers.</summary>
        /// <param name="Customers">Parámetros de entrada para la actualizacion de la Customers.</param>
        /// <returns>Entidad Customers Actualizada.</returns>
        Task<Customers> ActualizarCustomers(Customers Customers);

        /// <summary>Elimina la Customers.</summary>
        /// <param name="Id">Parámetro de entrada para la Eliminacion de la Customers.</param>
        /// <returns>Entidad Customers Eliminada.</returns>
        Task<Customers> EliminarCustomers(int Id);

        #endregion
    }
}
