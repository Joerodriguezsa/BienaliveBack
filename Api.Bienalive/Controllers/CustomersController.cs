
namespace Api.Bienalive.Controllers
{
    using AutoMapper;
    using Core.Bienalive.Interface;
    using Core.Bienalive.Dto.Customers;
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.Customers;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly IServiceUnitOfWork _iServiceUnitOfWork;
        private readonly IMapper _iMapper;

        public CustomersController(IMapper iMapper, IServiceUnitOfWork iServiceUnitOfWork)
        {
            _iMapper = iMapper;
            _iServiceUnitOfWork = iServiceUnitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomersDto>>> ConsultarCustomers([FromQuery] BusquedaCustomers filtros)
        {
            var data = await _iServiceUnitOfWork.Customers.ConsultarCustomers(_iMapper.Map<BusquedaCustomers>(filtros));
            return Ok(_iMapper.Map<List<CustomersDto>>(data));
        }

        [HttpPost]
        public async Task<ActionResult<CustomersDto>> CrearCustomers(CreacionCustomers dto)
        {
            var entidad = await _iServiceUnitOfWork.Customers.CrearCustomers(_iMapper.Map<Customers>(dto));
            return Ok(_iMapper.Map<CustomersDto>(entidad));
        }

        [HttpPut]
        public async Task<ActionResult<CustomersDto>> ActualizarCustomers(ActualizacionCustomers dto)
        {
            var entidad = await _iServiceUnitOfWork.Customers.ActualizarCustomers(_iMapper.Map<Customers>(dto));
            return Ok(_iMapper.Map<CustomersDto>(entidad));
        }

        [HttpDelete]
        public async Task<ActionResult<CustomersDto>> EliminarCustomers(int id)
        {
            var entidad = await _iServiceUnitOfWork.Customers.EliminarCustomers(id);
            return Ok(_iMapper.Map<CustomersDto>(entidad));
        }
    }
}
