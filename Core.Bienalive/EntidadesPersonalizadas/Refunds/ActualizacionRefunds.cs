namespace Core.Bienalive.EntidadesPersonalizadas.Refunds
{
    /// <summary>Inicialización de los parametros de la entidad Refunds.</summary>
    public class ActualizacionRefunds
    {
        /// <value>Llave primaria de la entidad.</value>
        public required long Id { get; set; }

        /// <value>Nombre.</value>
        public required string Name { get; set; } = string.Empty;
    }
}