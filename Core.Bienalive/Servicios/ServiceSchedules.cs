
using Core.Bienalive.Entidades;
using Core.Bienalive.EntidadesPersonalizadas.Schedules;
using Core.Bienalive.Interface;
using Core.Bienalive.Interface.Repositorio;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Utilitarios.Extenciones;

namespace Core.Bienalive.Servicios
{
    public class ServiceSchedules : IDLSchedules
    {
        private readonly IDLUnitOfWork _iDLUnitOfWork;

        public ServiceSchedules(IDLUnitOfWork iDLUnitOfWork)
        {
            _iDLUnitOfWork = iDLUnitOfWork;
        }

        public async Task<IEnumerable<Schedules>> ConsultarSchedules(BusquedaSchedules parametrosBusqueda)
        {
            Expression<Func<Schedules, bool>> filtro = parametrosBusqueda.CrearFiltro<Schedules>();
            return await _iDLUnitOfWork.DLSchedules.ConsultarLista(filtro);
        }

        public async Task<Schedules> CrearSchedules(Schedules entidad)
        {
            await _iDLUnitOfWork.DLSchedules.Adicionar(entidad);
            await _iDLUnitOfWork.SaveChangesAsync();
            return entidad;
        }

        public async Task<Schedules> ActualizarSchedules(Schedules entidad)
        {
            var registroDB = await _iDLUnitOfWork.DLSchedules.ConsultarPorId(entidad.Id)
                ?? throw new ValidationException($"The Schedules with ID {entidad.Id} does not exist.");



            _iDLUnitOfWork.DLSchedules.Actualizar(registroDB);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }

        public async Task<Schedules> EliminarSchedules(long id)
        {
            var registroDB = await _iDLUnitOfWork.DLSchedules.ConsultarPorId(id)
                ?? throw new ValidationException($"The Schedules with ID {id} does not exist.");

            await _iDLUnitOfWork.DLSchedules.Eliminar(id);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }
    }
}
