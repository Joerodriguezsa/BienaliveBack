
using Core.Bienalive.Entidades;
using Core.Bienalive.EntidadesPersonalizadas.PaymentMethods;
using Core.Bienalive.Interface;
using Core.Bienalive.Interface.Repositorio;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Utilitarios.Extenciones;

namespace Core.Bienalive.Servicios
{
    public class ServicePaymentMethods : IDLPaymentMethods
    {
        private readonly IDLUnitOfWork _iDLUnitOfWork;

        public ServicePaymentMethods(IDLUnitOfWork iDLUnitOfWork)
        {
            _iDLUnitOfWork = iDLUnitOfWork;
        }

        public async Task<IEnumerable<PaymentMethods>> ConsultarPaymentMethods(BusquedaPaymentMethods parametrosBusqueda)
        {
            Expression<Func<PaymentMethods, bool>> filtro = parametrosBusqueda.CrearFiltro<PaymentMethods>();
            return await _iDLUnitOfWork.DLPaymentMethods.ConsultarLista(filtro);
        }

        public async Task<PaymentMethods> CrearPaymentMethods(PaymentMethods entidad)
        {
            await _iDLUnitOfWork.DLPaymentMethods.Adicionar(entidad);
            await _iDLUnitOfWork.SaveChangesAsync();
            return entidad;
        }

        public async Task<PaymentMethods> ActualizarPaymentMethods(PaymentMethods entidad)
        {
            var registroDB = await _iDLUnitOfWork.DLPaymentMethods.ConsultarPorId(entidad.Id)
                ?? throw new ValidationException($"The PaymentMethods with ID {entidad.Id} does not exist.");

            _iDLUnitOfWork.DLPaymentMethods.Actualizar(registroDB);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }

        public async Task<PaymentMethods> EliminarPaymentMethods(int id)
        {
            var registroDB = await _iDLUnitOfWork.DLPaymentMethods.ConsultarPorId(id)
                ?? throw new ValidationException($"The PaymentMethods with ID {id} does not exist.");

            await _iDLUnitOfWork.DLPaymentMethods.Eliminar(id);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }
    }
}
