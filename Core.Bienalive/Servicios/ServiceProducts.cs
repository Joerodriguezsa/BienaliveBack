
using Core.Bienalive.Entidades;
using Core.Bienalive.EntidadesPersonalizadas.Products;
using Core.Bienalive.Interface;
using Core.Bienalive.Interface.Repositorio;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Utilitarios.Extenciones;

namespace Core.Bienalive.Servicios
{
    public class ServiceProducts : IDLProducts
    {
        private readonly IDLUnitOfWork _iDLUnitOfWork;

        public ServiceProducts(IDLUnitOfWork iDLUnitOfWork)
        {
            _iDLUnitOfWork = iDLUnitOfWork;
        }

        public async Task<IEnumerable<Products>> ConsultarProducts(BusquedaProducts parametrosBusqueda)
        {
            Expression<Func<Products, bool>> filtro = parametrosBusqueda.CrearFiltro<Products>();
            return await _iDLUnitOfWork.DLProducts.ConsultarLista(filtro);
        }

        public async Task<Products> CrearProducts(Products entidad)
        {
            await _iDLUnitOfWork.DLProducts.Adicionar(entidad);
            await _iDLUnitOfWork.SaveChangesAsync();
            return entidad;
        }

        public async Task<Products> ActualizarProducts(Products entidad)
        {
            var registroDB = await _iDLUnitOfWork.DLProducts.ConsultarPorId(entidad.Id)
                ?? throw new ValidationException($"The Products with ID {entidad.Id} does not exist.");

            _iDLUnitOfWork.DLProducts.Actualizar(registroDB);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }

        public async Task<Products> EliminarProducts(int id)
        {
            var registroDB = await _iDLUnitOfWork.DLProducts.ConsultarPorId(id)
                ?? throw new ValidationException($"The Products with ID {id} does not exist.");

            await _iDLUnitOfWork.DLProducts.Eliminar(id);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }
    }
}
