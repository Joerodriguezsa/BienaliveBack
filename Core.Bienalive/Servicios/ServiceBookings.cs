
using Core.Bienalive.Entidades;
using Core.Bienalive.EntidadesPersonalizadas.Bookings;
using Core.Bienalive.Interface;
using Core.Bienalive.Interface.Repositorio;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Utilitarios.Extenciones;

namespace Core.Bienalive.Servicios
{
    public class ServiceBookings : IDLBookings
    {
        private readonly IDLUnitOfWork _iDLUnitOfWork;

        public ServiceBookings(IDLUnitOfWork iDLUnitOfWork)
        {
            _iDLUnitOfWork = iDLUnitOfWork;
        }

        public async Task<IEnumerable<Bookings>> ConsultarBookings(BusquedaBookings parametrosBusqueda)
        {
            Expression<Func<Bookings, bool>> filtro = parametrosBusqueda.CrearFiltro<Bookings>();
            return await _iDLUnitOfWork.DLBookings.ConsultarLista(filtro);
        }

        public async Task<Bookings> CrearBookings(Bookings entidad)
        {
            await _iDLUnitOfWork.DLBookings.Adicionar(entidad);
            await _iDLUnitOfWork.SaveChangesAsync();
            return entidad;
        }

        public async Task<Bookings> ActualizarBookings(Bookings entidad)
        {
            var registroDB = await _iDLUnitOfWork.DLBookings.ConsultarPorId(entidad.Id)
                ?? throw new ValidationException($"The Bookings with ID {entidad.Id} does not exist.");

            registroDB.CustomerId = entidad.CustomerId;
            registroDB.TeamMemberId = entidad.TeamMemberId;
            registroDB.ServiceTimePriceId = entidad.ServiceTimePriceId;
            registroDB.StartAt = entidad.StartAt;
            registroDB.EndAt = entidad.EndAt;
            registroDB.Status = entidad.Status;

            _iDLUnitOfWork.DLBookings.Actualizar(registroDB);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }

        public async Task<Bookings> EliminarBookings(int id)
        {
            var registroDB = await _iDLUnitOfWork.DLBookings.ConsultarPorId(id)
                ?? throw new ValidationException($"The Bookings with ID {id} does not exist.");

            await _iDLUnitOfWork.DLBookings.Eliminar(id);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }
    }
}
