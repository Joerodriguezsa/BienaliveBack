namespace Core.Bienalive.EntidadesPersonalizadas.ProductImages
{
    /// <summary>Inicialización de los parametros de la entidad ProductImages.</summary>
    public class ActualizacionProductImages
    {
        /// <value>Llave primaria de la entidad.</value>
        public required long Id { get; set; }

        /// <value>Nombre.</value>
        public required string Name { get; set; } = string.Empty;
    }
}