namespace Core.Bienalive.Interface.Repositorio
{
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.PaymentMethods;

    public interface IDLPaymentMethods
    {
        #region Instancias

        /// <summary>Consulta la PaymentMethods.</summary>
        /// <param name="parametrosBusqueda">Parametros de entrada para la consulta.</param>
        /// <returns>Lista de PaymentMethods consultadas.</returns>
        Task<IEnumerable<PaymentMethods>> ConsultarPaymentMethods(BusquedaPaymentMethods parametrosBusqueda);

        /// <summary>Crea la entidad PaymentMethods.</summary>
        /// <param name="PaymentMethods">Parametros de entrada para la creacion.</param>
        /// <returns>Entidad PaymentMethods.</returns>
        Task<PaymentMethods> CrearPaymentMethods(PaymentMethods PaymentMethods);

        /// <summary>Actualiza la PaymentMethods.</summary>
        /// <param name="PaymentMethods">Parámetros de entrada para la actualizacion de la PaymentMethods.</param>
        /// <returns>Entidad PaymentMethods Actualizada.</returns>
        Task<PaymentMethods> ActualizarPaymentMethods(PaymentMethods PaymentMethods);

        /// <summary>Elimina la PaymentMethods.</summary>
        /// <param name="Id">Parámetro de entrada para la Eliminacion de la PaymentMethods.</param>
        /// <returns>Entidad PaymentMethods Eliminada.</returns>
        Task<PaymentMethods> EliminarPaymentMethods(int Id);

        #endregion
    }
}
