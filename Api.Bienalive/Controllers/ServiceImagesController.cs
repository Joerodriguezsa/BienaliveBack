namespace Api.Bienalive.Controllers
{
    using AutoMapper;
    using Core.Bienalive.Interface;
    using Core.Bienalive.Dto.ServiceImages;
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.ServiceImages;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class ServiceImagesController : ControllerBase
    {
        #region Variables

        /// <summary>Inyección de Dependecias de servicios.</summary>
        private readonly IServiceUnitOfWork _iServiceUnitOfWork;

        /// <summary>Inyeccion de convertidor o resolutor de modelos.</summary>
        private readonly IMapper _iMapper;

        #endregion Variables

        #region Constructor

        /// <summary>Inicializa una nueva instancia de la clase ParametricasController.</summary>
        /// <param name="iMapper">Inyección de convertidor o resolutor de modelos.</param>
        /// <param name="iServiceUnitOfWork">Inyección de dependecias de Servicios.</param>
        public ServiceImagesController(IMapper iMapper, IServiceUnitOfWork iServiceUnitOfWork)
        {
            _iMapper = iMapper;
            _iServiceUnitOfWork = iServiceUnitOfWork;
        }

        #endregion

        /// <summary>Consulta la ServiceImages.</summary>
        /// <param name="parametrosBusqueda">Parametros de entrada para la consulta.</param>
        /// <returns>Lista de ServiceImagess consultadas.</returns>
        [HttpGet]
        [Route("ConsultarServiceImages")]
        public async Task<ActionResult<IEnumerable<ServiceImagesDto>>> ConsultarServiceImages([FromQuery] BusquedaServiceImages parametrosBusqueda)
        {
            IEnumerable<ServiceImages> listaServiceImages = await _iServiceUnitOfWork.ServiceImages.ConsultarServiceImages(_iMapper.Map<BusquedaServiceImages>(parametrosBusqueda));
            return Ok(_iMapper.Map<List<ServiceImagesDto>>(listaServiceImages?.ToList()));
        }

        /// <summary>Crea la entidad ServiceImages.</summary>
        /// <param name="parametrosCreacion">Parametros de entrada para la creacion.</param>
        /// <returns>Entidad ServiceImagesSinNovedadDto.</returns>
        [HttpPost]
        [Route("CrearServiceImages")]
        public async Task<ActionResult<ServiceImagesDto>> CrearServiceImages(CreacionServiceImages parametrosCreacion)
        {
            ServiceImages ServiceImages = await _iServiceUnitOfWork.ServiceImages.CrearServiceImages(_iMapper.Map<ServiceImages>(parametrosCreacion));
            return Ok(_iMapper.Map<ServiceImagesDto>(ServiceImages));

        }

        /// <summary>Endpoint para la actualizacion de ServiceImages.</summary>
        /// <param name="parametrosActualizacion">Parámetros de entrada para la actualizacion de la ServiceImages.</param>
        /// <returns>Entidad ServiceImagesSinNovedadDto Actualizada.</returns>
        [HttpPut]
        [Route("ActualizarServiceImages")]
        public async Task<ActionResult<ServiceImagesDto>> ActualizarServiceImages(ActualizacionServiceImages parametrosActualizacion)
        {
            ServiceImages ServiceImages = await _iServiceUnitOfWork.ServiceImages.ActualizarServiceImages(_iMapper.Map<ServiceImages>(parametrosActualizacion));
            return Ok(_iMapper.Map<ServiceImagesDto>(ServiceImages));
        }

        /// <summary>Endpoint para la Eliminacion de ServiceImages.</summary>
        /// <param name="Id">Parámetro de entrada para la Eliminacion de la ServiceImages.</param>
        /// <returns>Entidad ServiceImagesSinNovedadDto Eliminada.</returns>
        [HttpDelete]
        [Route("EliminarServiceImages")]
        public async Task<ActionResult<ServiceImagesDto>> EliminarServiceImages(int Id)
        {
            ServiceImages ServiceImages = await _iServiceUnitOfWork.ServiceImages.EliminarServiceImages(Id);
            return Ok(_iMapper.Map<ServiceImagesDto>(ServiceImages));
        }
    }
}
