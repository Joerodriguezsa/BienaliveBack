
using Core.Bienalive.Entidades;
using Core.Bienalive.EntidadesPersonalizadas.SaleItems;
using Core.Bienalive.Interface;
using Core.Bienalive.Interface.Repositorio;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Utilitarios.Extenciones;

namespace Core.Bienalive.Servicios
{
    public class ServiceSaleItems : IDLSaleItems
    {
        private readonly IDLUnitOfWork _iDLUnitOfWork;

        public ServiceSaleItems(IDLUnitOfWork iDLUnitOfWork)
        {
            _iDLUnitOfWork = iDLUnitOfWork;
        }

        public async Task<IEnumerable<SaleItems>> ConsultarSaleItems(BusquedaSaleItems parametrosBusqueda)
        {
            Expression<Func<SaleItems, bool>> filtro = parametrosBusqueda.CrearFiltro<SaleItems>();
            return await _iDLUnitOfWork.DLSaleItems.ConsultarLista(filtro);
        }

        public async Task<SaleItems> CrearSaleItems(SaleItems entidad)
        {
            await _iDLUnitOfWork.DLSaleItems.Adicionar(entidad);
            await _iDLUnitOfWork.SaveChangesAsync();
            return entidad;
        }

        public async Task<SaleItems> ActualizarSaleItems(SaleItems entidad)
        {
            var registroDB = await _iDLUnitOfWork.DLSaleItems.ConsultarPorId(entidad.Id)
                ?? throw new ValidationException($"The SaleItems with ID {entidad.Id} does not exist.");

            _iDLUnitOfWork.DLSaleItems.Actualizar(registroDB);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }

        public async Task<SaleItems> EliminarSaleItems(int id)
        {
            var registroDB = await _iDLUnitOfWork.DLSaleItems.ConsultarPorId(id)
                ?? throw new ValidationException($"The SaleItems with ID {id} does not exist.");

            await _iDLUnitOfWork.DLSaleItems.Eliminar(id);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }
    }
}
