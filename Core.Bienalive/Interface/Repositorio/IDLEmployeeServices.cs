namespace Core.Bienalive.Interface.Repositorio
{
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.EmployeeServices;

    public interface IDLEmployeeServices
    {
        /// <summary>Consulta la EmployeeServices.</summary>
        /// <param name="parametrosBusqueda">Parámetros de entrada para la consulta.</param>
        /// <returns>Lista de EmployeeServices consultadas.</returns>
        Task<IEnumerable<EmployeeServices>> ConsultarEmployeeServices(BusquedaEmployeeServices parametrosBusqueda);

        /// <summary>Crea la entidad EmployeeServices.</summary>
        /// <param name="EmployeeServices">Parametros de entrada para la creacion.</param>
        /// <returns>Entidad EmployeeServices.</returns>
        Task<EmployeeServices> CrearEmployeeServices(EmployeeServices EmployeeServices);

        /// <summary>Actualiza la EmployeeServices.</summary>
        /// <param name="EmployeeServices">Parámetros de entrada para la actualizacion de la EmployeeServices.</param>
        /// <returns>Entidad EmployeeServices Actualizada.</returns>
        Task<EmployeeServices> ActualizarEmployeeServices(EmployeeServices EmployeeServices);

        /// <summary>Elimina la EmployeeServices.</summary>
        /// <param name="Id">Parámetro de entrada para la Eliminacion de la EmployeeServices.</param>
        /// <returns>Entidad EmployeeServices Eliminada.</returns>
        Task<EmployeeServices> EliminarEmployeeServices(int Id);
    }
}
