
namespace Api.Bienalive.Controllers
{
    using AutoMapper;
    using Core.Bienalive.Dto.ServicesTimePrice;
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.ServicesTimePrice;
    using Core.Bienalive.Interface;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class ServicesTimePriceController : ControllerBase
    {
        private readonly IServiceUnitOfWork _iServiceUnitOfWork;
        private readonly IMapper _iMapper;

        public ServicesTimePriceController(IMapper iMapper, IServiceUnitOfWork iServiceUnitOfWork)
        {
            _iMapper = iMapper;
            _iServiceUnitOfWork = iServiceUnitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ServicesTimePriceDto>>> ConsultarServicesTimePrice([FromQuery] BusquedaServicesTimePrice filtros)
        {
            var data = await _iServiceUnitOfWork.ServicesTimePrice.ConsultarServicesTimePrice(_iMapper.Map<BusquedaServicesTimePrice>(filtros));
            return Ok(_iMapper.Map<List<ServicesTimePriceDto>>(data));
        }

        [HttpPost]
        public async Task<ActionResult<ServicesTimePriceDto>> CrearServicesTimePrice(CreacionServicesTimePrice dto)
        {
            var entidad = await _iServiceUnitOfWork.ServicesTimePrice.CrearServicesTimePrice(_iMapper.Map<ServicesTimePrice>(dto));
            return Ok(_iMapper.Map<ServicesTimePriceDto>(entidad));
        }

        [HttpPut]
        public async Task<ActionResult<ServicesTimePriceDto>> ActualizarServicesTimePrice(ActualizacionServicesTimePrice dto)
        {
            var entidad = await _iServiceUnitOfWork.ServicesTimePrice.ActualizarServicesTimePrice(_iMapper.Map<ServicesTimePrice>(dto));
            return Ok(_iMapper.Map<ServicesTimePriceDto>(entidad));
        }

        [HttpDelete]
        public async Task<ActionResult<ServicesTimePriceDto>> EliminarServicesTimePrice(long id)
        {
            var entidad = await _iServiceUnitOfWork.ServicesTimePrice.EliminarServicesTimePrice(id);
            return Ok(_iMapper.Map<ServicesTimePriceDto>(entidad));
        }
    }
}
