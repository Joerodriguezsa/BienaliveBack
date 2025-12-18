
using Core.Bienalive.Entidades;
using Core.Bienalive.EntidadesPersonalizadas.Payments;
using Core.Bienalive.Interface;
using Core.Bienalive.Interface.Repositorio;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Utilitarios.Extenciones;

namespace Core.Bienalive.Servicios
{
    public class ServicePayments : IDLPayments
    {
        private readonly IDLUnitOfWork _iDLUnitOfWork;

        public ServicePayments(IDLUnitOfWork iDLUnitOfWork)
        {
            _iDLUnitOfWork = iDLUnitOfWork;
        }

        public async Task<IEnumerable<Payments>> ConsultarPayments(BusquedaPayments parametrosBusqueda)
        {
            Expression<Func<Payments, bool>> filtro = parametrosBusqueda.CrearFiltro<Payments>();
            return await _iDLUnitOfWork.DLPayments.ConsultarLista(filtro);
        }

        public async Task<Payments> CrearPayments(Payments entidad)
        {
            await _iDLUnitOfWork.DLPayments.Adicionar(entidad);
            await _iDLUnitOfWork.SaveChangesAsync();
            return entidad;
        }

        public async Task<Payments> ActualizarPayments(Payments entidad)
        {
            var registroDB = await _iDLUnitOfWork.DLPayments.ConsultarPorId(entidad.Id)
                ?? throw new ValidationException($"The Payments with ID {entidad.Id} does not exist.");

            _iDLUnitOfWork.DLPayments.Actualizar(registroDB);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }

        public async Task<Payments> EliminarPayments(int id)
        {
            var registroDB = await _iDLUnitOfWork.DLPayments.ConsultarPorId(id)
                ?? throw new ValidationException($"The Payments with ID {id} does not exist.");

            await _iDLUnitOfWork.DLPayments.Eliminar(id);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }
    }
}
