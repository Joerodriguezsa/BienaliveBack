namespace Api.Bienalive.Controllers
{
    using AutoMapper;
    using Core.Bienalive.Interface;
    using Core.Bienalive.Dto.Roles;
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.Roles;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class RolesController : ControllerBase
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
        public RolesController(IMapper iMapper, IServiceUnitOfWork iServiceUnitOfWork)
        {
            _iMapper = iMapper;
            _iServiceUnitOfWork = iServiceUnitOfWork;
        }

        #endregion

        /// <summary>Consulta la Roles.</summary>
        /// <param name="parametrosBusqueda">Parametros de entrada para la consulta.</param>
        /// <returns>Lista de Roless consultadas.</returns>
        [HttpGet]
        [Route("ConsultarRoles")]
        public async Task<ActionResult<IEnumerable<RolesDto>>> ConsultarRoles([FromQuery] BusquedaRoles parametrosBusqueda)
        {
            IEnumerable<Roles> listaRoles = await _iServiceUnitOfWork.ServicesRoles.ConsultarRoles(_iMapper.Map<BusquedaRoles>(parametrosBusqueda));
            return Ok(_iMapper.Map<List<RolesDto>>(listaRoles?.ToList()));
        }

        /// <summary>Crea la entidad Roles.</summary>
        /// <param name="parametrosCreacion">Parametros de entrada para la creacion.</param>
        /// <returns>Entidad RolesSinNovedadDto.</returns>
        [HttpPost]
        [Route("CrearRoles")]
        public async Task<ActionResult<RolesDto>> CrearRoles(CreacionRoles parametrosCreacion)
        {
            Roles Roles = await _iServiceUnitOfWork.ServicesRoles.CrearRoles(_iMapper.Map<Roles>(parametrosCreacion));
            return Ok(_iMapper.Map<RolesDto>(Roles));

        }

        /// <summary>Endpoint para la actualizacion de Roles.</summary>
        /// <param name="parametrosActualizacion">Parámetros de entrada para la actualizacion de la Roles.</param>
        /// <returns>Entidad RolesSinNovedadDto Actualizada.</returns>
        [HttpPut]
        [Route("ActualizarRoles")]
        public async Task<ActionResult<RolesDto>> ActualizarRoles(ActualizacionRoles parametrosActualizacion)
        {
            Roles Roles = await _iServiceUnitOfWork.ServicesRoles.ActualizarRoles(_iMapper.Map<Roles>(parametrosActualizacion));
            return Ok(_iMapper.Map<RolesDto>(Roles));
        }

        /// <summary>Endpoint para la Eliminacion de Roles.</summary>
        /// <param name="Id">Parámetro de entrada para la Eliminacion de la Roles.</param>
        /// <returns>Entidad RolesSinNovedadDto Eliminada.</returns>
        [HttpDelete]
        [Route("EliminarRoles")]
        public async Task<ActionResult<RolesDto>> EliminarRoles(int Id)
        {
            Roles Roles = await _iServiceUnitOfWork.ServicesRoles.EliminarRoles(Id);
            return Ok(_iMapper.Map<RolesDto>(Roles));
        }
    }
}
