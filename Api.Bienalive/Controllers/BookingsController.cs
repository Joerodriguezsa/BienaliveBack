
namespace Api.Bienalive.Controllers
{
    using AutoMapper;
    using Core.Bienalive.Interface;
    using Core.Bienalive.Dto.Bookings;
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.Bookings;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class BookingsController : ControllerBase
    {
        private readonly IServiceUnitOfWork _iServiceUnitOfWork;
        private readonly IMapper _iMapper;

        public BookingsController(IMapper iMapper, IServiceUnitOfWork iServiceUnitOfWork)
        {
            _iMapper = iMapper;
            _iServiceUnitOfWork = iServiceUnitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookingsDto>>> ConsultarBookings([FromQuery] BusquedaBookings filtros)
        {
            var data = await _iServiceUnitOfWork.Bookings.ConsultarBookings(_iMapper.Map<BusquedaBookings>(filtros));
            return Ok(_iMapper.Map<List<BookingsDto>>(data));
        }

        [HttpPost]
        public async Task<ActionResult<BookingsDto>> CrearBookings(CreacionBookings dto)
        {
            var entidad = await _iServiceUnitOfWork.Bookings.CrearBookings(_iMapper.Map<Bookings>(dto));
            return Ok(_iMapper.Map<BookingsDto>(entidad));
        }

        [HttpPut]
        public async Task<ActionResult<BookingsDto>> ActualizarBookings(ActualizacionBookings dto)
        {
            var entidad = await _iServiceUnitOfWork.Bookings.ActualizarBookings(_iMapper.Map<Bookings>(dto));
            return Ok(_iMapper.Map<BookingsDto>(entidad));
        }

        [HttpDelete]
        public async Task<ActionResult<BookingsDto>> EliminarBookings(int id)
        {
            var entidad = await _iServiceUnitOfWork.Bookings.EliminarBookings(id);
            return Ok(_iMapper.Map<BookingsDto>(entidad));
        }
    }
}
