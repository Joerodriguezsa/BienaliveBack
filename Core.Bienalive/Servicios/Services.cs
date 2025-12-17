using Core.Bienalive.Dto.ServiceImages;
using Core.Bienalive.Dto.Services;
using Core.Bienalive.EntidadesPersonalizadas.Services;
using Core.Bienalive.Interface;
using Core.Bienalive.Interface.Repositorio;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Utilitarios.Extenciones;

namespace Core.Bienalive.Servicios
{
    public class Services : IDLServices
    {
        #region Variables

        /// <summary>Instancia de la unidad de trabajo - DLUnitOfWork.</summary>
        private readonly IDLUnitOfWork _iDLUnitOfWork;
        private List<string> errores = new List<string>();

        #endregion

        #region Constructor

        ///<summary>Inicializa una nueva instancia de la clase ServicesService.</summary>
        /// <param name="iDLUnitOfWork">Inyeccion de dependencias de la unidad de trabajo - DLUnitOfWork.</param>
        public Services(IDLUnitOfWork iDLUnitOfWork)
        {
            _iDLUnitOfWork = iDLUnitOfWork;
        }

        #endregion

        #region Metodos

        /// <summary>Consulta la Services.</summary>
        /// <param name="parametrosBusqueda">Parametros de entrada para la consulta.</param>
        /// <returns>Lista de Servicess consultadas.</returns>
        public async Task<IEnumerable<Entidades.Services>> ConsultarServices(BusquedaServices parametrosBusqueda)
        {
            Expression<Func<Entidades.Services, bool>> filtro = parametrosBusqueda.CrearFiltro<Entidades.Services>();
            return await _iDLUnitOfWork.DLServices.ConsultarLista(filtro);            
        }

        public async Task<IEnumerable<ServicesDto>> ConsultarServicesWithImages(BusquedaServices parametrosBusqueda)
        {
            Expression<Func<Entidades.Services, bool>> filtro = parametrosBusqueda.CrearFiltro<Entidades.Services>();
            var servicios = await _iDLUnitOfWork.DLServices.ConsultarLista(filtro);
            
            var ids = servicios.Select(s => s.Id).ToList();
            
            var imagenes = await _iDLUnitOfWork.DLServiceImages.ConsultarLista(img => ids.Contains(img.ServiceId));

            var imagenesPorServicio = imagenes
                .GroupBy(img => img.ServiceId)
                .ToDictionary(g => g.Key, g => g.ToList());

            var resultado = servicios.Select(s => new ServicesDto
            {
                Id = s.Id,
                Name = s.Name,
                ShortDescription = s.ShortDescription,
                LongDescription = s.LongDescription,
                Time1 = s.Time1,
                Price1 = s.Price1,
                Time2 = s.Time2,
                Price2 = s.Price2,
                Time3 = s.Time3,
                Price3 = s.Price3,
                Time4 = s.Time4,
                Price4 = s.Price4,
                Time5 = s.Time5,
                Price5 = s.Price5,
                Active = s.Active,
                ServiceImages = imagenesPorServicio.ContainsKey(s.Id)
                    ? new LinkedList<ServiceImagesDto>(
                        imagenesPorServicio[s.Id].Select(img => new ServiceImagesDto
                        {
                            Id = img.Id,
                            ServiceId = img.ServiceId,
                            ImageUrl = img.ImageUrl,
                            TipoImagenId = img.TipoImagenId
                        }))
                    : new LinkedList<ServiceImagesDto>()
            });

            return resultado;
        }

        /// <summary>Crea la entidad Services.</summary>
        /// <param name="Services">Parametros de entrada para la creacion.</param>
        /// <returns>Entidad Services.</returns>
        public async Task<Entidades.Services> CrearServices(Entidades.Services Services)
        {
            await ValidarServices(Services);
            // Verificar que los valores requeridos no sean nulos.
            await _iDLUnitOfWork.DLServices.Adicionar(Services);
            await _iDLUnitOfWork.SaveChangesAsync();
            return Services;
        }

        /// <summary>Actualiza la Services.</summary>
        /// <param name="Services">Parametros de entrada para la actualizacion de la Services.</param>
        /// <returns>Entidad Services Actualizada.</returns>
        public async Task<Entidades.Services> ActualizarServices(Entidades.Services Services)
        {
            Entidades.Services registroDB = await _iDLUnitOfWork.DLServices.ConsultarPorId(Services.Id)
                ?? throw new ValidationException($"The Services with ID {Services.Id} does not exist.");

            registroDB.Name = Services.Name ?? registroDB.Name;            
            registroDB.ShortDescription = Services.ShortDescription ?? registroDB.ShortDescription;
            registroDB.LongDescription = Services.LongDescription ?? registroDB.LongDescription;            
            registroDB.Time1 = Services.Time1 == 0 ? registroDB.Time1 : Services.Time1;            
            registroDB.Price1 = Services.Price1 ?? registroDB.Price1;
            registroDB.Time2 = Services.Time2 == 0 ? registroDB.Time2 : Services.Time2;
            registroDB.Price2 = Services.Price2 ?? registroDB.Price2;
            registroDB.Time3 = Services.Time3 == 0 ? registroDB.Time3 : Services.Time3;
            registroDB.Price3 = Services.Price3 ?? registroDB.Price3;
            registroDB.Active = Services.Active ?? registroDB.Active;

            await ValidarServices(registroDB);

            _iDLUnitOfWork.DLServices.Actualizar(registroDB);

            await _iDLUnitOfWork.SaveChangesAsync();

            return registroDB;
        }

        /// <summary>Elimina la Services.</summary>
        /// <param name="ServicesId">Parametro de entrada para la Eliminacion de la Services.</param>
        /// <returns>Entidad Services Eliminada.</returns>
        public async Task<Entidades.Services> EliminarServices(int ServicesId)
        {

            Entidades.Services registroDB = await _iDLUnitOfWork.DLServices.ConsultarPorId(ServicesId)
                ?? throw new ValidationException($"La Services con ID {ServicesId} no existe.");

            await _iDLUnitOfWork.DLServices.Eliminar(ServicesId);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }

        #endregion

        #region Validaciones

        /// <summary>Valida los Parametros de Services.</summary>
        /// <param name="Services">Parametro de entrada para la validacion.</param>
        /// <returns>Este metodo no retorna ningún valor.</returns>
        private async Task ValidarServices(Entidades.Services Services)
        {

            //if (Services.ServicesPrioridad <= 0)
            //    errores.Add("ServicesPrioridad debe ser mayor a 0.");

            if (string.IsNullOrWhiteSpace(Services.ShortDescription))
                errores.Add("The short description of the Services cannot be null or empty.");

            if (string.IsNullOrWhiteSpace(Services.LongDescription))
                errores.Add("The long description of the Services cannot be null or empty.");

            //Regex hexadecimalRegex = new Regex(@"^#[0-9A-Fa-f]{6}$");

            //if (!hexadecimalRegex.IsMatch(Services.ServicesColor))
            //    errores.Add("ServicesColor debe ser un valor hexadecimal valido. (por ejemplo: #A3B4C5).");

            //if (!hexadecimalRegex.IsMatch(Services.ServicesColorLetra))
            //    errores.Add("ServicesColorLetra debe ser un valor hexadecimal valido. (por ejemplo: #A3B4C5).");

            //if (Services.NovedadId != null)
            //{
            //    Novedad novedad = await _iDLUnitOfWork.DLNovedad.ConsultarPorId((int)Services.NovedadId);
            //    if (novedad == null)
            //        errores.Add($"La novedad con ID {Services.NovedadId} no existe.");
            //}



            //// Verificar si ya existe una Services con la misma NovedadId asignada
            //IEnumerable<Services> ServicesExistente = await _iDLUnitOfWork.DLServices.ConsultarLista(c => c.NovedadId == Services.NovedadId);
            //if (ServicesExistente.Any() && ServicesExistente.First().ServicesId != Services.ServicesId)
            //{
            //    string ServicesExistenteStr = string.Join(", ", ServicesExistente.Select(c => $"Id {c.ServicesId}: {c.ServicesDescripcion}"));
            //    errores.Add($"La novedad con ID {Services.NovedadId} ya esta asignada a la siguiente Services: {ServicesExistenteStr}.");
            //}


            //// Validación de prioridades repetidas
            //IEnumerable<Services> prioridadExistente = await _iDLUnitOfWork.DLServices.ConsultarLista(c => c.ServicesPrioridad == Services.ServicesPrioridad);
            //if (prioridadExistente.Any(c => c.ServicesId != Services.ServicesId))
            //    errores.Add($"Ya existe una Services con prioridad {Services.ServicesPrioridad}.");

            //// Validación de descripción duplicada
            //IEnumerable<Services> descripcionExistente = await _iDLUnitOfWork.DLServices.ConsultarLista(c => c.ServicesDescripcion == Services.ServicesDescripcion);
            //if (descripcionExistente.Any(c => c.ServicesId != Services.ServicesId))
            //    errores.Add($"Ya existe una Services con la descripción: {Services.ServicesDescripcion}.");

            if (errores.Any())
                throw new ValidationException(string.Join(" | ", errores));
        }

        #endregion
    }
}
