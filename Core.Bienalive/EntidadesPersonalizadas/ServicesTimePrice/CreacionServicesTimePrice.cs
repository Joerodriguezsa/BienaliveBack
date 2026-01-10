namespace Core.Bienalive.EntidadesPersonalizadas.ServicesTimePrice
{
    public class CreacionServicesTimePrice
    {        

        /// <value>Identificador del servicio.</value>
        public long? ServiceId { get; set; }

        /// <value>Tiempo asociado al servicio.</value>
        public int? Time { get; set; }

        /// <value>Precio para el tiempo.</value>
        public decimal? Price { get; set; }
    }
}
