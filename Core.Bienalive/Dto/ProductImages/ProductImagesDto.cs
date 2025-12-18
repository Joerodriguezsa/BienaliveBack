namespace Core.Bienalive.Dto.ProductImages
{
    public class ProductImagesDto
    {
        /// <value>Llave primaria de la entidad.</value>
        public long Id { get; set; }

        /// <value>Identificador del producto.</value>
        public long? ProductId { get; set; }

        /// <value>URL de la imagen.</value>
        public string ImageUrl { get; set; } = string.Empty;
    }
}
