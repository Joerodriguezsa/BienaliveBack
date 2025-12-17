using Core.Bienalive.EntidadesPersonalizadas.ServiceImages;
using Core.Bienalive.Interface;
using Core.Bienalive.Interface.Repositorio;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Utilitarios.Extenciones;

namespace Core.Bienalive.Servicios
{
    public class ServiceImages : IDLServiceImages
    {
        #region Variables

        /// <summary>Instancia de la unidad de trabajo - DLUnitOfWork.</summary>
        private readonly IDLUnitOfWork _iDLUnitOfWork;
        private List<string> errores = new List<string>();

        #endregion

        #region Constructor

        ///<summary>Inicializa una nueva instancia de la clase ServiceImagesService.</summary>
        /// <param name="iDLUnitOfWork">Inyeccion de dependencias de la unidad de trabajo - DLUnitOfWork.</param>
        public ServiceImages(IDLUnitOfWork iDLUnitOfWork)
        {
            _iDLUnitOfWork = iDLUnitOfWork;
        }

        #endregion

        #region Metodos

        /// <summary>Consulta la ServiceImages.</summary>
        /// <param name="parametrosBusqueda">Parametros de entrada para la consulta.</param>
        /// <returns>Lista de ServiceImagess consultadas.</returns>
        public async Task<IEnumerable<Entidades.ServiceImages>> ConsultarServiceImages(BusquedaServiceImages parametrosBusqueda)
        {
            Expression<Func<Entidades.ServiceImages, bool>> filtro = parametrosBusqueda.CrearFiltro<Entidades.ServiceImages>();
            return await _iDLUnitOfWork.DLServiceImages.ConsultarLista(filtro);            
        }

        /// <summary>Crea la entidad ServiceImages.</summary>
        /// <param name="ServiceImages">Parametros de entrada para la creacion.</param>
        /// <returns>Entidad ServiceImages.</returns>
        public async Task<Entidades.ServiceImages> CrearServiceImages(Entidades.ServiceImages ServiceImages)
        {
            await ValidarServiceImages(ServiceImages);
            // Verificar que los valores requeridos no sean nulos.
            await _iDLUnitOfWork.DLServiceImages.Adicionar(ServiceImages);
            await _iDLUnitOfWork.SaveChangesAsync();
            return ServiceImages;
        }

        /// <summary>Actualiza la ServiceImages.</summary>
        /// <param name="ServiceImages">Parametros de entrada para la actualizacion de la ServiceImages.</param>
        /// <returns>Entidad ServiceImages Actualizada.</returns>
        public async Task<Entidades.ServiceImages> ActualizarServiceImages(Entidades.ServiceImages ServiceImages)
        {
            Entidades.ServiceImages registroDB = await _iDLUnitOfWork.DLServiceImages.ConsultarPorId(ServiceImages.Id)
                ?? throw new ValidationException($"The ServiceImages with ID {ServiceImages.Id} does not exist.");

            registroDB.ImageUrl = ServiceImages.ImageUrl ?? registroDB.ImageUrl;
            registroDB.TipoImagenId = ServiceImages.TipoImagenId == 0 ? registroDB.TipoImagenId : ServiceImages.TipoImagenId;

            await ValidarServiceImages(registroDB);

            _iDLUnitOfWork.DLServiceImages.Actualizar(registroDB);

            await _iDLUnitOfWork.SaveChangesAsync();

            return registroDB;
        }

        /// <summary>Elimina la ServiceImages.</summary>
        /// <param name="ServiceImagesId">Parametro de entrada para la Eliminacion de la ServiceImages.</param>
        /// <returns>Entidad ServiceImages Eliminada.</returns>
        public async Task<Entidades.ServiceImages> EliminarServiceImages(int ServiceImagesId)
        {

            Entidades.ServiceImages registroDB = await _iDLUnitOfWork.DLServiceImages.ConsultarPorId(ServiceImagesId)
                ?? throw new ValidationException($"La ServiceImages con ID {ServiceImagesId} no existe.");

            await _iDLUnitOfWork.DLServiceImages.Eliminar(ServiceImagesId);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }

        #endregion

        #region Validaciones

        /// <summary>Valida los Parametros de ServiceImages.</summary>
        /// <param name="ServiceImages">Parametro de entrada para la validacion.</param>
        /// <returns>Este metodo no retorna ningún valor.</returns>
        private async Task ValidarServiceImages(Entidades.ServiceImages ServiceImages)
        {

            //if (ServiceImages.ServiceImagesPrioridad <= 0)
            //    errores.Add("ServiceImagesPrioridad debe ser mayor a 0.");

            if (string.IsNullOrWhiteSpace(ServiceImages.ImageUrl))
                errores.Add("The url image description of the ServiceImages cannot be null or empty.");

            //if (string.IsNullOrWhiteSpace(ServiceImages.LongDescription))
            //    errores.Add("The long description of the ServiceImages cannot be null or empty.");

            //Regex hexadecimalRegex = new Regex(@"^#[0-9A-Fa-f]{6}$");

            //if (!hexadecimalRegex.IsMatch(ServiceImages.ServiceImagesColor))
            //    errores.Add("ServiceImagesColor debe ser un valor hexadecimal valido. (por ejemplo: #A3B4C5).");

            //if (!hexadecimalRegex.IsMatch(ServiceImages.ServiceImagesColorLetra))
            //    errores.Add("ServiceImagesColorLetra debe ser un valor hexadecimal valido. (por ejemplo: #A3B4C5).");

            //if (ServiceImages.NovedadId != null)
            //{
            //    Novedad novedad = await _iDLUnitOfWork.DLNovedad.ConsultarPorId((int)ServiceImages.NovedadId);
            //    if (novedad == null)
            //        errores.Add($"La novedad con ID {ServiceImages.NovedadId} no existe.");
            //}



            //// Verificar si ya existe una ServiceImages con la misma NovedadId asignada
            //IEnumerable<ServiceImages> ServiceImagesExistente = await _iDLUnitOfWork.DLServiceImages.ConsultarLista(c => c.NovedadId == ServiceImages.NovedadId);
            //if (ServiceImagesExistente.Any() && ServiceImagesExistente.First().ServiceImagesId != ServiceImages.ServiceImagesId)
            //{
            //    string ServiceImagesExistenteStr = string.Join(", ", ServiceImagesExistente.Select(c => $"Id {c.ServiceImagesId}: {c.ServiceImagesDescripcion}"));
            //    errores.Add($"La novedad con ID {ServiceImages.NovedadId} ya esta asignada a la siguiente ServiceImages: {ServiceImagesExistenteStr}.");
            //}


            //// Validación de prioridades repetidas
            //IEnumerable<ServiceImages> prioridadExistente = await _iDLUnitOfWork.DLServiceImages.ConsultarLista(c => c.ServiceImagesPrioridad == ServiceImages.ServiceImagesPrioridad);
            //if (prioridadExistente.Any(c => c.ServiceImagesId != ServiceImages.ServiceImagesId))
            //    errores.Add($"Ya existe una ServiceImages con prioridad {ServiceImages.ServiceImagesPrioridad}.");

            //// Validación de descripción duplicada
            //IEnumerable<ServiceImages> descripcionExistente = await _iDLUnitOfWork.DLServiceImages.ConsultarLista(c => c.ServiceImagesDescripcion == ServiceImages.ServiceImagesDescripcion);
            //if (descripcionExistente.Any(c => c.ServiceImagesId != ServiceImages.ServiceImagesId))
            //    errores.Add($"Ya existe una ServiceImages con la descripción: {ServiceImages.ServiceImagesDescripcion}.");

            if (errores.Any())
                throw new ValidationException(string.Join(" | ", errores));
        }

        #endregion
    }
}
