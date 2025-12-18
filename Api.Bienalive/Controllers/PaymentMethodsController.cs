
namespace Api.Bienalive.Controllers
{
    using AutoMapper;
    using Core.Bienalive.Interface;
    using Core.Bienalive.Dto.PaymentMethods;
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.PaymentMethods;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class PaymentMethodsController : ControllerBase
    {
        private readonly IServiceUnitOfWork _iServiceUnitOfWork;
        private readonly IMapper _iMapper;

        public PaymentMethodsController(IMapper iMapper, IServiceUnitOfWork iServiceUnitOfWork)
        {
            _iMapper = iMapper;
            _iServiceUnitOfWork = iServiceUnitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PaymentMethodsDto>>> ConsultarPaymentMethods([FromQuery] BusquedaPaymentMethods filtros)
        {
            var data = await _iServiceUnitOfWork.PaymentMethods.ConsultarPaymentMethods(_iMapper.Map<BusquedaPaymentMethods>(filtros));
            return Ok(_iMapper.Map<List<PaymentMethodsDto>>(data));
        }

        [HttpPost]
        public async Task<ActionResult<PaymentMethodsDto>> CrearPaymentMethods(CreacionPaymentMethods dto)
        {
            var entidad = await _iServiceUnitOfWork.PaymentMethods.CrearPaymentMethods(_iMapper.Map<PaymentMethods>(dto));
            return Ok(_iMapper.Map<PaymentMethodsDto>(entidad));
        }

        [HttpPut]
        public async Task<ActionResult<PaymentMethodsDto>> ActualizarPaymentMethods(ActualizacionPaymentMethods dto)
        {
            var entidad = await _iServiceUnitOfWork.PaymentMethods.ActualizarPaymentMethods(_iMapper.Map<PaymentMethods>(dto));
            return Ok(_iMapper.Map<PaymentMethodsDto>(entidad));
        }

        [HttpDelete]
        public async Task<ActionResult<PaymentMethodsDto>> EliminarPaymentMethods(int id)
        {
            var entidad = await _iServiceUnitOfWork.PaymentMethods.EliminarPaymentMethods(id);
            return Ok(_iMapper.Map<PaymentMethodsDto>(entidad));
        }
    }
}
