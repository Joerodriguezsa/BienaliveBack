namespace Core.Bienalive.Interface.Repositorio
{
    using Core.Bienalive.Dto.Services;
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.Services;

    public interface IDLServices
	{
		#region Instancias

		/// <summary>Consulta la Services.</summary>
		/// <param name="parametrosBusqueda">Parametros de entrada para la consulta.</param>
		/// <returns>Lista de Servicess consultadas.</returns>
		Task<IEnumerable<Services>> ConsultarServices(BusquedaServices parametrosBusqueda);

		/// <summary>Crea la entidad Services.</summary>
		/// <param name="Services">Parametros de entrada para la creacion.</param>
		/// <returns>Entidad Services.</returns>
		Task<Services> CrearServices(Services Services);

		/// <summary>Actualiza la Services.</summary>
		/// <param name="Services">Parámetros de entrada para la actualizacion de la Services.</param>
		/// <returns>Entidad Services Actualizada.</returns>
		Task<Services> ActualizarServices(Services Services);

		/// <summary>Elimina la Services.</summary>
		/// <param name="Id">Parámetro de entrada para la Eliminacion de la Services.</param>
		/// <returns>Entidad Services Eliminada.</returns>
		Task<Services> EliminarServices(long Id);

        Task<IEnumerable<ServicesDto>> ConsultarServicesWithImages(BusquedaServices parametrosBusqueda);
        #endregion

    }
}
