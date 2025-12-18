namespace Core.Bienalive.Interface.Repositorio
{
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.ProductImages;

    public interface IDLProductImages
    {
        #region Instancias

        Task<IEnumerable<ProductImages>> ConsultarProductImages(BusquedaProductImages parametrosBusqueda);

        Task<ProductImages> CrearProductImages(ProductImages entidad);

        Task<ProductImages> ActualizarProductImages(ProductImages entidad);

        Task<ProductImages> EliminarProductImages(int id);

        #endregion
    }
}