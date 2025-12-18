
namespace Api.Bienalive.Controllers
{
    using AutoMapper;
    using Core.Bienalive.Interface;
    using Core.Bienalive.Dto.AppointmentStatuses;
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.AppointmentStatuses;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentStatusesController : ControllerBase
    {
        private readonly IServiceUnitOfWork _iServiceUnitOfWork;
        private readonly IMapper _iMapper;

        public AppointmentStatusesController(IMapper iMapper, IServiceUnitOfWork iServiceUnitOfWork)
        {
            _iMapper = iMapper;
            _iServiceUnitOfWork = iServiceUnitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppointmentStatusesDto>>> ConsultarAppointmentStatuses([FromQuery] BusquedaAppointmentStatuses filtros)
        {
            var data = await _iServiceUnitOfWork.AppointmentStatuses.ConsultarAppointmentStatuses(_iMapper.Map<BusquedaAppointmentStatuses>(filtros));
            return Ok(_iMapper.Map<List<AppointmentStatusesDto>>(data));
        }

        [HttpPost]
        public async Task<ActionResult<AppointmentStatusesDto>> CrearAppointmentStatuses(CreacionAppointmentStatuses dto)
        {
            var entidad = await _iServiceUnitOfWork.AppointmentStatuses.CrearAppointmentStatuses(_iMapper.Map<AppointmentStatuses>(dto));
            return Ok(_iMapper.Map<AppointmentStatusesDto>(entidad));
        }

        [HttpPut]
        public async Task<ActionResult<AppointmentStatusesDto>> ActualizarAppointmentStatuses(ActualizacionAppointmentStatuses dto)
        {
            var entidad = await _iServiceUnitOfWork.AppointmentStatuses.ActualizarAppointmentStatuses(_iMapper.Map<AppointmentStatuses>(dto));
            return Ok(_iMapper.Map<AppointmentStatusesDto>(entidad));
        }

        [HttpDelete]
        public async Task<ActionResult<AppointmentStatusesDto>> EliminarAppointmentStatuses(int id)
        {
            var entidad = await _iServiceUnitOfWork.AppointmentStatuses.EliminarAppointmentStatuses(id);
            return Ok(_iMapper.Map<AppointmentStatusesDto>(entidad));
        }
    }
}
