
namespace Api.Bienalive.Controllers
{
    using AutoMapper;
    using Core.Bienalive.Interface;
    using Core.Bienalive.Dto.Appointments;
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.Appointments;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentsController : ControllerBase
    {
        private readonly IServiceUnitOfWork _iServiceUnitOfWork;
        private readonly IMapper _iMapper;

        public AppointmentsController(IMapper iMapper, IServiceUnitOfWork iServiceUnitOfWork)
        {
            _iMapper = iMapper;
            _iServiceUnitOfWork = iServiceUnitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppointmentsDto>>> ConsultarAppointments([FromQuery] BusquedaAppointments filtros)
        {
            var data = await _iServiceUnitOfWork.Appointments.ConsultarAppointments(_iMapper.Map<BusquedaAppointments>(filtros));
            return Ok(_iMapper.Map<List<AppointmentsDto>>(data));
        }

        [HttpPost]
        public async Task<ActionResult<AppointmentsDto>> CrearAppointments(CreacionAppointments dto)
        {
            var entidad = await _iServiceUnitOfWork.Appointments.CrearAppointments(_iMapper.Map<Appointments>(dto));
            return Ok(_iMapper.Map<AppointmentsDto>(entidad));
        }

        [HttpPut]
        public async Task<ActionResult<AppointmentsDto>> ActualizarAppointments(ActualizacionAppointments dto)
        {
            var entidad = await _iServiceUnitOfWork.Appointments.ActualizarAppointments(_iMapper.Map<Appointments>(dto));
            return Ok(_iMapper.Map<AppointmentsDto>(entidad));
        }

        [HttpDelete]
        public async Task<ActionResult<AppointmentsDto>> EliminarAppointments(long id)
        {
            var entidad = await _iServiceUnitOfWork.Appointments.EliminarAppointments(id);
            return Ok(_iMapper.Map<AppointmentsDto>(entidad));
        }
    }
}
