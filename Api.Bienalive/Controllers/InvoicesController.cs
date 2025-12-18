
namespace Api.Bienalive.Controllers
{
    using AutoMapper;
    using Core.Bienalive.Interface;
    using Core.Bienalive.Dto.Invoices;
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.Invoices;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class InvoicesController : ControllerBase
    {
        private readonly IServiceUnitOfWork _iServiceUnitOfWork;
        private readonly IMapper _iMapper;

        public InvoicesController(IMapper iMapper, IServiceUnitOfWork iServiceUnitOfWork)
        {
            _iMapper = iMapper;
            _iServiceUnitOfWork = iServiceUnitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<InvoicesDto>>> ConsultarInvoices([FromQuery] BusquedaInvoices filtros)
        {
            var data = await _iServiceUnitOfWork.Invoices.ConsultarInvoices(_iMapper.Map<BusquedaInvoices>(filtros));
            return Ok(_iMapper.Map<List<InvoicesDto>>(data));
        }

        [HttpPost]
        public async Task<ActionResult<InvoicesDto>> CrearInvoices(CreacionInvoices dto)
        {
            var entidad = await _iServiceUnitOfWork.Invoices.CrearInvoices(_iMapper.Map<Invoices>(dto));
            return Ok(_iMapper.Map<InvoicesDto>(entidad));
        }

        [HttpPut]
        public async Task<ActionResult<InvoicesDto>> ActualizarInvoices(ActualizacionInvoices dto)
        {
            var entidad = await _iServiceUnitOfWork.Invoices.ActualizarInvoices(_iMapper.Map<Invoices>(dto));
            return Ok(_iMapper.Map<InvoicesDto>(entidad));
        }

        [HttpDelete]
        public async Task<ActionResult<InvoicesDto>> EliminarInvoices(int id)
        {
            var entidad = await _iServiceUnitOfWork.Invoices.EliminarInvoices(id);
            return Ok(_iMapper.Map<InvoicesDto>(entidad));
        }
    }
}
