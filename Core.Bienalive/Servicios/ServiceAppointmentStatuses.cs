
using Core.Bienalive.Entidades;
using Core.Bienalive.EntidadesPersonalizadas.AppointmentStatuses;
using Core.Bienalive.Interface;
using Core.Bienalive.Interface.Repositorio;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Utilitarios.Extenciones;

namespace Core.Bienalive.Servicios
{
    public class ServiceAppointmentStatuses : IDLAppointmentStatuses
    {
        private readonly IDLUnitOfWork _iDLUnitOfWork;

        public ServiceAppointmentStatuses(IDLUnitOfWork iDLUnitOfWork)
        {
            _iDLUnitOfWork = iDLUnitOfWork;
        }

        public async Task<IEnumerable<AppointmentStatuses>> ConsultarAppointmentStatuses(BusquedaAppointmentStatuses parametrosBusqueda)
        {
            Expression<Func<AppointmentStatuses, bool>> filtro = parametrosBusqueda.CrearFiltro<AppointmentStatuses>();
            return await _iDLUnitOfWork.DLAppointmentStatuses.ConsultarLista(filtro);
        }

        public async Task<AppointmentStatuses> CrearAppointmentStatuses(AppointmentStatuses entidad)
        {
            await _iDLUnitOfWork.DLAppointmentStatuses.Adicionar(entidad);
            await _iDLUnitOfWork.SaveChangesAsync();
            return entidad;
        }

        public async Task<AppointmentStatuses> ActualizarAppointmentStatuses(AppointmentStatuses entidad)
        {
            var registroDB = await _iDLUnitOfWork.DLAppointmentStatuses.ConsultarPorId(entidad.Id)
                ?? throw new ValidationException($"The AppointmentStatuses with ID {entidad.Id} does not exist.");

            _iDLUnitOfWork.DLAppointmentStatuses.Actualizar(registroDB);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }

        public async Task<AppointmentStatuses> EliminarAppointmentStatuses(long id)
        {
            var registroDB = await _iDLUnitOfWork.DLAppointmentStatuses.ConsultarPorId(id)
                ?? throw new ValidationException($"The AppointmentStatuses with ID {id} does not exist.");

            await _iDLUnitOfWork.DLAppointmentStatuses.Eliminar(id);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }
    }
}
