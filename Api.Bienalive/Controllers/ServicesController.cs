namespace Api.Bienalive.Controllers
{
    using AutoMapper;
    using Core.Bienalive.Dto.Services;
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.Services;
    using Core.Bienalive.Interface;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class ServicesController : ControllerBase
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
        public ServicesController(IMapper iMapper, IServiceUnitOfWork iServiceUnitOfWork)
        {
            _iMapper = iMapper;
            _iServiceUnitOfWork = iServiceUnitOfWork;
        }

        #endregion

        /// <summary>Consulta Services.</summary>
        /// <param name="parametrosBusqueda">Parametros de entrada para la consulta.</param>
        /// <returns>Lista de Servicess consultadas.</returns>
        [HttpGet]
        [Authorize]
        [Route("ConsultarServices")]
        public async Task<ActionResult<IEnumerable<ServicesDto>>> ConsultarServices([FromQuery] BusquedaServices parametrosBusqueda)
        {
            IEnumerable<Services> listaServices = await _iServiceUnitOfWork.ServicesService.ConsultarServices(_iMapper.Map<BusquedaServices>(parametrosBusqueda));
            return Ok(_iMapper.Map<List<ServicesDto>>(listaServices?.ToList()));
        }

        /// <summary>Consulta Services Images.</summary>
        /// <param name="parametrosBusqueda">Parametros de entrada para la consulta.</param>
        /// <returns>Lista de Servicess consultadas.</returns>
        [HttpGet]
        [Route("ConsultarServicesImages")]
        public async Task<ActionResult<IEnumerable<ServicesDto>>> ConsultarServicesImages([FromQuery] BusquedaServices parametrosBusqueda)
        {
            var listaServices = await _iServiceUnitOfWork.ServicesService.ConsultarServicesWithImages(_iMapper.Map<BusquedaServices>(parametrosBusqueda));
            return Ok(_iMapper.Map<List<ServicesDto>>(listaServices?.ToList()));
        }

        /// <summary>Crea la entidad Services.</summary>
        /// <param name="parametrosCreacion">Parametros de entrada para la creacion.</param>
        /// <returns>Entidad ServicesSinNovedadDto.</returns>
        [HttpPost]
        [Route("CrearServices")]
        public async Task<ActionResult<ServicesDto>> CrearServices(CreacionServices parametrosCreacion)
        {
            Services Services = await _iServiceUnitOfWork.ServicesService.CrearServices(_iMapper.Map<Services>(parametrosCreacion));
            return Ok(_iMapper.Map<ServicesDto>(Services));

        }

        /// <summary>Endpoint para la actualizacion de Services.</summary>
        /// <param name="parametrosActualizacion">Parámetros de entrada para la actualizacion de la Services.</param>
        /// <returns>Entidad ServicesSinNovedadDto Actualizada.</returns>
        [HttpPut]
        [Route("ActualizarServices")]
        public async Task<ActionResult<ServicesDto>> ActualizarServices(ActualizacionServices parametrosActualizacion)
        {
            Services Services = await _iServiceUnitOfWork.ServicesService.ActualizarServices(_iMapper.Map<Services>(parametrosActualizacion));
            return Ok(_iMapper.Map<ServicesDto>(Services));
        }

        /// <summary>Endpoint para la Eliminacion de Services.</summary>
        /// <param name="Id">Parámetro de entrada para la Eliminacion de la Services.</param>
        /// <returns>Entidad ServicesSinNovedadDto Eliminada.</returns>
        [HttpDelete]
        [Route("EliminarServices")]
        public async Task<ActionResult<ServicesDto>> EliminarServices(int Id)
        {
            Services Services = await _iServiceUnitOfWork.ServicesService.EliminarServices(Id);
            return Ok(_iMapper.Map<ServicesDto>(Services));
        }
    }
}
