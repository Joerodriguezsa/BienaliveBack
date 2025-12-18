
using Core.Bienalive.Entidades;
using Core.Bienalive.EntidadesPersonalizadas.Customers;
using Core.Bienalive.Interface;
using Core.Bienalive.Interface.Repositorio;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Utilitarios.Extenciones;

namespace Core.Bienalive.Servicios
{
    public class ServiceCustomers : IDLCustomers
    {
        private readonly IDLUnitOfWork _iDLUnitOfWork;

        public ServiceCustomers(IDLUnitOfWork iDLUnitOfWork)
        {
            _iDLUnitOfWork = iDLUnitOfWork;
        }

        public async Task<IEnumerable<Customers>> ConsultarCustomers(BusquedaCustomers parametrosBusqueda)
        {
            Expression<Func<Customers, bool>> filtro = parametrosBusqueda.CrearFiltro<Customers>();
            return await _iDLUnitOfWork.DLCustomers.ConsultarLista(filtro);
        }

        public async Task<Customers> CrearCustomers(Customers entidad)
        {
            await _iDLUnitOfWork.DLCustomers.Adicionar(entidad);
            await _iDLUnitOfWork.SaveChangesAsync();
            return entidad;
        }

        public async Task<Customers> ActualizarCustomers(Customers entidad)
        {
            var registroDB = await _iDLUnitOfWork.DLCustomers.ConsultarPorId(entidad.Id)
                ?? throw new ValidationException($"The Customers with ID {entidad.Id} does not exist.");

            _iDLUnitOfWork.DLCustomers.Actualizar(registroDB);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }

        public async Task<Customers> EliminarCustomers(int id)
        {
            var registroDB = await _iDLUnitOfWork.DLCustomers.ConsultarPorId(id)
                ?? throw new ValidationException($"The Customers with ID {id} does not exist.");

            await _iDLUnitOfWork.DLCustomers.Eliminar(id);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }
    }
}
