
namespace Api.Bienalive.Controllers
{
    using AutoMapper;
    using Core.Bienalive.Interface;
    using Core.Bienalive.Dto.Sales;
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.Sales;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class SalesController : ControllerBase
    {
        private readonly IServiceUnitOfWork _iServiceUnitOfWork;
        private readonly IMapper _iMapper;

        public SalesController(IMapper iMapper, IServiceUnitOfWork iServiceUnitOfWork)
        {
            _iMapper = iMapper;
            _iServiceUnitOfWork = iServiceUnitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SalesDto>>> ConsultarSales([FromQuery] BusquedaSales filtros)
        {
            var data = await _iServiceUnitOfWork.Sales.ConsultarSales(_iMapper.Map<BusquedaSales>(filtros));
            return Ok(_iMapper.Map<List<SalesDto>>(data));
        }

        [HttpPost]
        public async Task<ActionResult<SalesDto>> CrearSales(CreacionSales dto)
        {
            var entidad = await _iServiceUnitOfWork.Sales.CrearSales(_iMapper.Map<Sales>(dto));
            return Ok(_iMapper.Map<SalesDto>(entidad));
        }

        [HttpPut]
        public async Task<ActionResult<SalesDto>> ActualizarSales(ActualizacionSales dto)
        {
            var entidad = await _iServiceUnitOfWork.Sales.ActualizarSales(_iMapper.Map<Sales>(dto));
            return Ok(_iMapper.Map<SalesDto>(entidad));
        }

        [HttpDelete]
        public async Task<ActionResult<SalesDto>> EliminarSales(int id)
        {
            var entidad = await _iServiceUnitOfWork.Sales.EliminarSales(id);
            return Ok(_iMapper.Map<SalesDto>(entidad));
        }
    }
}
