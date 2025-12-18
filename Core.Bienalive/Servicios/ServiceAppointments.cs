
using Core.Bienalive.Entidades;
using Core.Bienalive.EntidadesPersonalizadas.Appointments;
using Core.Bienalive.Interface;
using Core.Bienalive.Interface.Repositorio;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Utilitarios.Extenciones;

namespace Core.Bienalive.Servicios
{
    public class ServiceAppointments : IDLAppointments
    {
        private readonly IDLUnitOfWork _iDLUnitOfWork;

        public ServiceAppointments(IDLUnitOfWork iDLUnitOfWork)
        {
            _iDLUnitOfWork = iDLUnitOfWork;
        }

        public async Task<IEnumerable<Appointments>> ConsultarAppointments(BusquedaAppointments parametrosBusqueda)
        {
            Expression<Func<Appointments, bool>> filtro = parametrosBusqueda.CrearFiltro<Appointments>();
            return await _iDLUnitOfWork.DLAppointments.ConsultarLista(filtro);
        }

        public async Task<Appointments> CrearAppointments(Appointments entidad)
        {
            await _iDLUnitOfWork.DLAppointments.Adicionar(entidad);
            await _iDLUnitOfWork.SaveChangesAsync();
            return entidad;
        }

        public async Task<Appointments> ActualizarAppointments(Appointments entidad)
        {
            var registroDB = await _iDLUnitOfWork.DLAppointments.ConsultarPorId(entidad.Id)
                ?? throw new ValidationException($"The Appointments with ID {entidad.Id} does not exist.");

            _iDLUnitOfWork.DLAppointments.Actualizar(registroDB);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }

        public async Task<Appointments> EliminarAppointments(int id)
        {
            var registroDB = await _iDLUnitOfWork.DLAppointments.ConsultarPorId(id)
                ?? throw new ValidationException($"The Appointments with ID {id} does not exist.");

            await _iDLUnitOfWork.DLAppointments.Eliminar(id);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }
    }
}
