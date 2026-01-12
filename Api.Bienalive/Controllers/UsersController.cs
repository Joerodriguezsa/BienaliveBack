
namespace Api.Bienalive.Controllers
{
    using AutoMapper;
    using Core.Bienalive.Interface;
    using Core.Bienalive.Dto.Users;
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.Users;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IServiceUnitOfWork _iServiceUnitOfWork;
        private readonly IMapper _iMapper;

        public UsersController(IMapper iMapper, IServiceUnitOfWork iServiceUnitOfWork)
        {
            _iMapper = iMapper;
            _iServiceUnitOfWork = iServiceUnitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsersDto>>> ConsultarUsers([FromQuery] BusquedaUsers filtros)
        {
            var data = await _iServiceUnitOfWork.Users.ConsultarUsers(_iMapper.Map<BusquedaUsers>(filtros));
            return Ok(_iMapper.Map<List<UsersDto>>(data));
        }

        [HttpPost]
        public async Task<ActionResult<UsersDto>> CrearUsers(CreacionUsers dto)
        {
            var entidad = await _iServiceUnitOfWork.Users.CrearUsers(_iMapper.Map<Users>(dto));
            return Ok(_iMapper.Map<UsersDto>(entidad));
        }

        [HttpPut]
        public async Task<ActionResult<UsersDto>> ActualizarUsers(ActualizacionUsers dto)
        {
            var entidad = await _iServiceUnitOfWork.Users.ActualizarUsers(_iMapper.Map<Users>(dto));
            return Ok(_iMapper.Map<UsersDto>(entidad));
        }

        [HttpDelete]
        public async Task<ActionResult<UsersDto>> EliminarUsers(long id)
        {
            var entidad = await _iServiceUnitOfWork.Users.EliminarUsers(id);
            return Ok(_iMapper.Map<UsersDto>(entidad));
        }
    }
}
