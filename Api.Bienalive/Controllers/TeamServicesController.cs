
namespace Api.Bienalive.Controllers
{
    using AutoMapper;
    using Core.Bienalive.Interface;
    using Core.Bienalive.Dto.TeamServices;
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.TeamServices;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class TeamServicesController : ControllerBase
    {
        private readonly IServiceUnitOfWork _iServiceUnitOfWork;
        private readonly IMapper _iMapper;

        public TeamServicesController(IMapper iMapper, IServiceUnitOfWork iServiceUnitOfWork)
        {
            _iMapper = iMapper;
            _iServiceUnitOfWork = iServiceUnitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamServicesDto>>> ConsultarTeamServices([FromQuery] BusquedaTeamServices filtros)
        {
            var data = await _iServiceUnitOfWork.TeamServices.ConsultarTeamServices(_iMapper.Map<BusquedaTeamServices>(filtros));
            return Ok(_iMapper.Map<List<TeamServicesDto>>(data));
        }

        [HttpPost]
        public async Task<ActionResult<TeamServicesDto>> CrearTeamServices(CreacionTeamServices dto)
        {
            var entidad = await _iServiceUnitOfWork.TeamServices.CrearTeamServices(_iMapper.Map<TeamServices>(dto));
            return Ok(_iMapper.Map<TeamServicesDto>(entidad));
        }

        [HttpPut]
        public async Task<ActionResult<TeamServicesDto>> ActualizarTeamServices(ActualizacionTeamServices dto)
        {
            var entidad = await _iServiceUnitOfWork.TeamServices.ActualizarTeamServices(_iMapper.Map<TeamServices>(dto));
            return Ok(_iMapper.Map<TeamServicesDto>(entidad));
        }

        [HttpDelete]
        public async Task<ActionResult<TeamServicesDto>> EliminarTeamServices(int id)
        {
            var entidad = await _iServiceUnitOfWork.TeamServices.EliminarTeamServices(id);
            return Ok(_iMapper.Map<TeamServicesDto>(entidad));
        }
    }
}
