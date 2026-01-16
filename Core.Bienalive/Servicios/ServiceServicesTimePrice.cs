
using Core.Bienalive.Entidades;
using Core.Bienalive.EntidadesPersonalizadas.ServicesTimePrice;
using Core.Bienalive.Interface;
using Core.Bienalive.Interface.Repositorio;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Utilitarios.Extenciones;

namespace Core.Bienalive.Servicios
{
    public class ServiceServicesTimePrice : IDLServicesTimePrice
    {
        private readonly IDLUnitOfWork _iDLUnitOfWork;

        public ServiceServicesTimePrice(IDLUnitOfWork iDLUnitOfWork)
        {
            _iDLUnitOfWork = iDLUnitOfWork;
        }

        public async Task<IEnumerable<ServicesTimePrice>> ConsultarServicesTimePrice(BusquedaServicesTimePrice parametrosBusqueda)
        {
            Expression<Func<ServicesTimePrice, bool>> filtro = parametrosBusqueda.CrearFiltro<ServicesTimePrice>();
            return await _iDLUnitOfWork.DLServicesTimePrice.ConsultarLista(filtro);
        }

        public async Task<ServicesTimePrice> CrearServicesTimePrice(ServicesTimePrice servicesTimePrice)
        {
            await _iDLUnitOfWork.DLServicesTimePrice.Adicionar(servicesTimePrice);
            await _iDLUnitOfWork.SaveChangesAsync();
            return servicesTimePrice;
        }

        public async Task<ServicesTimePrice> ActualizarServicesTimePrice(ServicesTimePrice servicesTimePrice)
        {
            var registroDB = await _iDLUnitOfWork.DLServicesTimePrice.ConsultarPorId(servicesTimePrice.Id)
                ?? throw new ValidationException($"The ServicesTimePrice with ID {servicesTimePrice.Id} does not exist.");

            registroDB.Time = servicesTimePrice.Time ?? registroDB.Time;
            registroDB.Price = servicesTimePrice.Price ?? registroDB.Price;

            _iDLUnitOfWork.DLServicesTimePrice.Actualizar(registroDB);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }

        public async Task<ServicesTimePrice> EliminarServicesTimePrice(long id)
        {
            var registroDB = await _iDLUnitOfWork.DLServicesTimePrice.ConsultarPorId(id)
                ?? throw new ValidationException($"The ServicesTimePrice with ID {id} does not exist.");

            await _iDLUnitOfWork.DLServicesTimePrice.Eliminar(id);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }
    }
}
