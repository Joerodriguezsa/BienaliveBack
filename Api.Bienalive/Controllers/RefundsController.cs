
namespace Api.Bienalive.Controllers
{
    using AutoMapper;
    using Core.Bienalive.Interface;
    using Core.Bienalive.Dto.Refunds;
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.Refunds;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class RefundsController : ControllerBase
    {
        private readonly IServiceUnitOfWork _iServiceUnitOfWork;
        private readonly IMapper _iMapper;

        public RefundsController(IMapper iMapper, IServiceUnitOfWork iServiceUnitOfWork)
        {
            _iMapper = iMapper;
            _iServiceUnitOfWork = iServiceUnitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<RefundsDto>>> ConsultarRefunds([FromQuery] BusquedaRefunds filtros)
        {
            var data = await _iServiceUnitOfWork.Refunds.ConsultarRefunds(_iMapper.Map<BusquedaRefunds>(filtros));
            return Ok(_iMapper.Map<List<RefundsDto>>(data));
        }

        [HttpPost]
        public async Task<ActionResult<RefundsDto>> CrearRefunds(CreacionRefunds dto)
        {
            var entidad = await _iServiceUnitOfWork.Refunds.CrearRefunds(_iMapper.Map<Refunds>(dto));
            return Ok(_iMapper.Map<RefundsDto>(entidad));
        }

        [HttpPut]
        public async Task<ActionResult<RefundsDto>> ActualizarRefunds(ActualizacionRefunds dto)
        {
            var entidad = await _iServiceUnitOfWork.Refunds.ActualizarRefunds(_iMapper.Map<Refunds>(dto));
            return Ok(_iMapper.Map<RefundsDto>(entidad));
        }

        [HttpDelete]
        public async Task<ActionResult<RefundsDto>> EliminarRefunds(int id)
        {
            var entidad = await _iServiceUnitOfWork.Refunds.EliminarRefunds(id);
            return Ok(_iMapper.Map<RefundsDto>(entidad));
        }
    }
}
