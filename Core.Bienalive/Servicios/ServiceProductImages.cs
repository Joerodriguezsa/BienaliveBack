
using Core.Bienalive.Entidades;
using Core.Bienalive.EntidadesPersonalizadas.ProductImages;
using Core.Bienalive.Interface;
using Core.Bienalive.Interface.Repositorio;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Utilitarios.Extenciones;

namespace Core.Bienalive.Servicios
{
    public class ServiceProductImages : IDLProductImages
    {
        private readonly IDLUnitOfWork _iDLUnitOfWork;

        public ServiceProductImages(IDLUnitOfWork iDLUnitOfWork)
        {
            _iDLUnitOfWork = iDLUnitOfWork;
        }

        public async Task<IEnumerable<ProductImages>> ConsultarProductImages(BusquedaProductImages parametrosBusqueda)
        {
            Expression<Func<ProductImages, bool>> filtro = parametrosBusqueda.CrearFiltro<ProductImages>();
            return await _iDLUnitOfWork.DLProductImages.ConsultarLista(filtro);
        }

        public async Task<ProductImages> CrearProductImages(ProductImages entidad)
        {
            await _iDLUnitOfWork.DLProductImages.Adicionar(entidad);
            await _iDLUnitOfWork.SaveChangesAsync();
            return entidad;
        }

        public async Task<ProductImages> ActualizarProductImages(ProductImages entidad)
        {
            var registroDB = await _iDLUnitOfWork.DLProductImages.ConsultarPorId(entidad.Id)
                ?? throw new ValidationException($"The ProductImages with ID {entidad.Id} does not exist.");

            _iDLUnitOfWork.DLProductImages.Actualizar(registroDB);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }

        public async Task<ProductImages> EliminarProductImages(int id)
        {
            var registroDB = await _iDLUnitOfWork.DLProductImages.ConsultarPorId(id)
                ?? throw new ValidationException($"The ProductImages with ID {id} does not exist.");

            await _iDLUnitOfWork.DLProductImages.Eliminar(id);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }
    }
}
