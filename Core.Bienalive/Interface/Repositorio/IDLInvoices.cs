namespace Core.Bienalive.Interface.Repositorio
{
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.Invoices;

    public interface IDLInvoices
    {
        #region Instancias

        /// <summary>Consulta la Invoices.</summary>
        /// <param name="parametrosBusqueda">Parametros de entrada para la consulta.</param>
        /// <returns>Lista de Invoices consultadas.</returns>
        Task<IEnumerable<Invoices>> ConsultarInvoices(BusquedaInvoices parametrosBusqueda);

        /// <summary>Crea la entidad Invoices.</summary>
        /// <param name="Invoices">Parametros de entrada para la creacion.</param>
        /// <returns>Entidad Invoices.</returns>
        Task<Invoices> CrearInvoices(Invoices Invoices);

        /// <summary>Actualiza la Invoices.</summary>
        /// <param name="Invoices">Parámetros de entrada para la actualizacion de la Invoices.</param>
        /// <returns>Entidad Invoices Actualizada.</returns>
        Task<Invoices> ActualizarInvoices(Invoices Invoices);

        /// <summary>Elimina la Invoices.</summary>
        /// <param name="Id">Parámetro de entrada para la Eliminacion de la Invoices.</param>
        /// <returns>Entidad Invoices Eliminada.</returns>
        Task<Invoices> EliminarInvoices(int Id);

        #endregion
    }
}
