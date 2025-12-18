namespace Core.Bienalive.Interface.Repositorio
{
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.Payments;

    public interface IDLPayments
    {
        #region Instancias

        /// <summary>Consulta la Payments.</summary>
        /// <param name="parametrosBusqueda">Parametros de entrada para la consulta.</param>
        /// <returns>Lista de Payments consultadas.</returns>
        Task<IEnumerable<Payments>> ConsultarPayments(BusquedaPayments parametrosBusqueda);

        /// <summary>Crea la entidad Payments.</summary>
        /// <param name="Payments">Parametros de entrada para la creacion.</param>
        /// <returns>Entidad Payments.</returns>
        Task<Payments> CrearPayments(Payments Payments);

        /// <summary>Actualiza la Payments.</summary>
        /// <param name="Payments">Parámetros de entrada para la actualizacion de la Payments.</param>
        /// <returns>Entidad Payments Actualizada.</returns>
        Task<Payments> ActualizarPayments(Payments Payments);

        /// <summary>Elimina la Payments.</summary>
        /// <param name="Id">Parámetro de entrada para la Eliminacion de la Payments.</param>
        /// <returns>Entidad Payments Eliminada.</returns>
        Task<Payments> EliminarPayments(int Id);

        #endregion
    }
}
