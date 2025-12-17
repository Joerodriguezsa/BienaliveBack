namespace Core.Bienalive.Interface.Repositorio
{
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.ServiceImages;

    public interface IDLServiceImages
	{
		#region Instancias

		/// <summary>Consulta la ServiceImages.</summary>
		/// <param name="parametrosBusqueda">Parametros de entrada para la consulta.</param>
		/// <returns>Lista de ServiceImagess consultadas.</returns>
		Task<IEnumerable<ServiceImages>> ConsultarServiceImages(BusquedaServiceImages parametrosBusqueda);

		/// <summary>Crea la entidad ServiceImages.</summary>
		/// <param name="ServiceImages">Parametros de entrada para la creacion.</param>
		/// <returns>Entidad ServiceImages.</returns>
		Task<ServiceImages> CrearServiceImages(ServiceImages ServiceImages);

		/// <summary>Actualiza la ServiceImages.</summary>
		/// <param name="ServiceImages">Parámetros de entrada para la actualizacion de la ServiceImages.</param>
		/// <returns>Entidad ServiceImages Actualizada.</returns>
		Task<ServiceImages> ActualizarServiceImages(ServiceImages ServiceImages);

		/// <summary>Elimina la ServiceImages.</summary>
		/// <param name="Id">Parámetro de entrada para la Eliminacion de la ServiceImages.</param>
		/// <returns>Entidad ServiceImages Eliminada.</returns>
		Task<ServiceImages> EliminarServiceImages(int Id);
		#endregion

	}
}
