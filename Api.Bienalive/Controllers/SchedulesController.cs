
namespace Api.Bienalive.Controllers
{
    using AutoMapper;
    using Core.Bienalive.Interface;
    using Core.Bienalive.Dto.Schedules;
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.Schedules;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class SchedulesController : ControllerBase
    {
        private readonly IServiceUnitOfWork _iServiceUnitOfWork;
        private readonly IMapper _iMapper;

        public SchedulesController(IMapper iMapper, IServiceUnitOfWork iServiceUnitOfWork)
        {
            _iMapper = iMapper;
            _iServiceUnitOfWork = iServiceUnitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SchedulesDto>>> ConsultarSchedules([FromQuery] BusquedaSchedules filtros)
        {
            var data = await _iServiceUnitOfWork.Schedules.ConsultarSchedules(_iMapper.Map<BusquedaSchedules>(filtros));
            return Ok(_iMapper.Map<List<SchedulesDto>>(data));
        }

        [HttpPost]
        public async Task<ActionResult<SchedulesDto>> CrearSchedules(CreacionSchedules dto)
        {
            var entidad = await _iServiceUnitOfWork.Schedules.CrearSchedules(_iMapper.Map<Schedules>(dto));
            return Ok(_iMapper.Map<SchedulesDto>(entidad));
        }

        [HttpPut]
        public async Task<ActionResult<SchedulesDto>> ActualizarSchedules(ActualizacionSchedules dto)
        {
            var entidad = await _iServiceUnitOfWork.Schedules.ActualizarSchedules(_iMapper.Map<Schedules>(dto));
            return Ok(_iMapper.Map<SchedulesDto>(entidad));
        }

        [HttpDelete]
        public async Task<ActionResult<SchedulesDto>> EliminarSchedules(long id)
        {
            var entidad = await _iServiceUnitOfWork.Schedules.EliminarSchedules(id);
            return Ok(_iMapper.Map<SchedulesDto>(entidad));
        }
    }
}
