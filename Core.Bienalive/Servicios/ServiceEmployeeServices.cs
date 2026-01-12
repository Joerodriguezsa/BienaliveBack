using Core.Bienalive.Entidades;
using Core.Bienalive.EntidadesPersonalizadas.EmployeeServices;
using Core.Bienalive.Interface;
using Core.Bienalive.Interface.Repositorio;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Utilitarios.Extenciones;

namespace Core.Bienalive.Servicios
{
    public class ServiceEmployeeServices : IDLEmployeeServices
    {
        private readonly IDLUnitOfWork _iDLUnitOfWork;

        public ServiceEmployeeServices(IDLUnitOfWork iDLUnitOfWork)
        {
            _iDLUnitOfWork = iDLUnitOfWork;
        }

        public async Task<IEnumerable<EmployeeServices>> ConsultarEmployeeServices(BusquedaEmployeeServices parametrosBusqueda)
        {
            Expression<Func<EmployeeServices, bool>> filtro = parametrosBusqueda.CrearFiltro<EmployeeServices>();
            return await _iDLUnitOfWork.DLEmployeeServices.ConsultarLista(filtro);
        }

        public async Task<EmployeeServices> CrearEmployeeServices(EmployeeServices entidad)
        {
            await _iDLUnitOfWork.DLEmployeeServices.Adicionar(entidad);
            await _iDLUnitOfWork.SaveChangesAsync();
            return entidad;
        }

        public async Task<EmployeeServices> ActualizarEmployeeServices(EmployeeServices entidad)
        {
            var registroDB = await _iDLUnitOfWork.DLEmployeeServices.ConsultarPorId(entidad.Id)
                ?? throw new ValidationException($"The EmployeeServices with ID {entidad.Id} does not exist.");

            registroDB.TeamMemberId = entidad.TeamMemberId;
            registroDB.ServiceId = entidad.ServiceId;
            registroDB.Active = entidad.Active;

            _iDLUnitOfWork.DLEmployeeServices.Actualizar(registroDB);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }

        public async Task<EmployeeServices> EliminarEmployeeServices(int id)
        {
            var registroDB = await _iDLUnitOfWork.DLEmployeeServices.ConsultarPorId(id)
                ?? throw new ValidationException($"The EmployeeServices with ID {id} does not exist.");

            await _iDLUnitOfWork.DLEmployeeServices.Eliminar(id);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }
    }
}
