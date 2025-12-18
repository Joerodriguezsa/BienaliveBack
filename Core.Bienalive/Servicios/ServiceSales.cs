
using Core.Bienalive.Entidades;
using Core.Bienalive.EntidadesPersonalizadas.Sales;
using Core.Bienalive.Interface;
using Core.Bienalive.Interface.Repositorio;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Utilitarios.Extenciones;

namespace Core.Bienalive.Servicios
{
    public class ServiceSales : IDLSales
    {
        private readonly IDLUnitOfWork _iDLUnitOfWork;

        public ServiceSales(IDLUnitOfWork iDLUnitOfWork)
        {
            _iDLUnitOfWork = iDLUnitOfWork;
        }

        public async Task<IEnumerable<Sales>> ConsultarSales(BusquedaSales parametrosBusqueda)
        {
            Expression<Func<Sales, bool>> filtro = parametrosBusqueda.CrearFiltro<Sales>();
            return await _iDLUnitOfWork.DLSales.ConsultarLista(filtro);
        }

        public async Task<Sales> CrearSales(Sales entidad)
        {
            await _iDLUnitOfWork.DLSales.Adicionar(entidad);
            await _iDLUnitOfWork.SaveChangesAsync();
            return entidad;
        }

        public async Task<Sales> ActualizarSales(Sales entidad)
        {
            var registroDB = await _iDLUnitOfWork.DLSales.ConsultarPorId(entidad.Id)
                ?? throw new ValidationException($"The Sales with ID {entidad.Id} does not exist.");

            _iDLUnitOfWork.DLSales.Actualizar(registroDB);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }

        public async Task<Sales> EliminarSales(int id)
        {
            var registroDB = await _iDLUnitOfWork.DLSales.ConsultarPorId(id)
                ?? throw new ValidationException($"The Sales with ID {id} does not exist.");

            await _iDLUnitOfWork.DLSales.Eliminar(id);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }
    }
}
