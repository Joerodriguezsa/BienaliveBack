
namespace Api.Bienalive.Controllers
{
    using AutoMapper;
    using Core.Bienalive.Interface;
    using Core.Bienalive.Dto.TeamMembers;
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.TeamMembers;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class TeamMembersController : ControllerBase
    {
        private readonly IServiceUnitOfWork _iServiceUnitOfWork;
        private readonly IMapper _iMapper;

        public TeamMembersController(IMapper iMapper, IServiceUnitOfWork iServiceUnitOfWork)
        {
            _iMapper = iMapper;
            _iServiceUnitOfWork = iServiceUnitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeamMembersDto>>> ConsultarTeamMembers([FromQuery] BusquedaTeamMembers filtros)
        {
            var data = await _iServiceUnitOfWork.TeamMembers.ConsultarTeamMembers(_iMapper.Map<BusquedaTeamMembers>(filtros));
            return Ok(_iMapper.Map<List<TeamMembersDto>>(data));
        }

        [HttpGet]
        [Route("ConsultarTeamMembersComplete")]
        public async Task<ActionResult<IEnumerable<TeamMembersDto>>> ConsultarTeamMembersComplete([FromQuery] BusquedaTeamMembers filtros)
        {
            var data = await _iServiceUnitOfWork.TeamMembers.ConsultarTeamMembersComplete(_iMapper.Map<BusquedaTeamMembers>(filtros));
            return Ok(_iMapper.Map<List<TeamMembersDto>>(data));
        }

        [HttpPost]
        public async Task<ActionResult<TeamMembersDto>> CrearTeamMembers(CreacionTeamMembers dto)
        {
            var entidad = await _iServiceUnitOfWork.TeamMembers.CrearTeamMembers(_iMapper.Map<TeamMembers>(dto));
            return Ok(_iMapper.Map<TeamMembersDto>(entidad));
        }

        [HttpPut]
        public async Task<ActionResult<TeamMembersDto>> ActualizarTeamMembers(ActualizacionTeamMembers dto)
        {
            var entidad = await _iServiceUnitOfWork.TeamMembers.ActualizarTeamMembers(_iMapper.Map<TeamMembers>(dto));
            return Ok(_iMapper.Map<TeamMembersDto>(entidad));
        }

        [HttpDelete]
        public async Task<ActionResult<TeamMembersDto>> EliminarTeamMembers(long id)
        {
            var entidad = await _iServiceUnitOfWork.TeamMembers.EliminarTeamMembers(id);
            return Ok(_iMapper.Map<TeamMembersDto>(entidad));
        }
    }
}
