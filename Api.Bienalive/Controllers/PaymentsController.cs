
namespace Api.Bienalive.Controllers
{
    using AutoMapper;
    using Core.Bienalive.Interface;
    using Core.Bienalive.Dto.Payments;
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.Payments;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class PaymentsController : ControllerBase
    {
        private readonly IServiceUnitOfWork _iServiceUnitOfWork;
        private readonly IMapper _iMapper;

        public PaymentsController(IMapper iMapper, IServiceUnitOfWork iServiceUnitOfWork)
        {
            _iMapper = iMapper;
            _iServiceUnitOfWork = iServiceUnitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PaymentsDto>>> ConsultarPayments([FromQuery] BusquedaPayments filtros)
        {
            var data = await _iServiceUnitOfWork.Payments.ConsultarPayments(_iMapper.Map<BusquedaPayments>(filtros));
            return Ok(_iMapper.Map<List<PaymentsDto>>(data));
        }

        [HttpPost]
        public async Task<ActionResult<PaymentsDto>> CrearPayments(CreacionPayments dto)
        {
            var entidad = await _iServiceUnitOfWork.Payments.CrearPayments(_iMapper.Map<Payments>(dto));
            return Ok(_iMapper.Map<PaymentsDto>(entidad));
        }

        [HttpPut]
        public async Task<ActionResult<PaymentsDto>> ActualizarPayments(ActualizacionPayments dto)
        {
            var entidad = await _iServiceUnitOfWork.Payments.ActualizarPayments(_iMapper.Map<Payments>(dto));
            return Ok(_iMapper.Map<PaymentsDto>(entidad));
        }

        [HttpDelete]
        public async Task<ActionResult<PaymentsDto>> EliminarPayments(int id)
        {
            var entidad = await _iServiceUnitOfWork.Payments.EliminarPayments(id);
            return Ok(_iMapper.Map<PaymentsDto>(entidad));
        }
    }
}
