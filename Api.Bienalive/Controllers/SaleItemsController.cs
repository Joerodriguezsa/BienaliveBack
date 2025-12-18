
namespace Api.Bienalive.Controllers
{
    using AutoMapper;
    using Core.Bienalive.Interface;
    using Core.Bienalive.Dto.SaleItems;
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.SaleItems;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class SaleItemsController : ControllerBase
    {
        private readonly IServiceUnitOfWork _iServiceUnitOfWork;
        private readonly IMapper _iMapper;

        public SaleItemsController(IMapper iMapper, IServiceUnitOfWork iServiceUnitOfWork)
        {
            _iMapper = iMapper;
            _iServiceUnitOfWork = iServiceUnitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SaleItemsDto>>> ConsultarSaleItems([FromQuery] BusquedaSaleItems filtros)
        {
            var data = await _iServiceUnitOfWork.SaleItems.ConsultarSaleItems(_iMapper.Map<BusquedaSaleItems>(filtros));
            return Ok(_iMapper.Map<List<SaleItemsDto>>(data));
        }

        [HttpPost]
        public async Task<ActionResult<SaleItemsDto>> CrearSaleItems(CreacionSaleItems dto)
        {
            var entidad = await _iServiceUnitOfWork.SaleItems.CrearSaleItems(_iMapper.Map<SaleItems>(dto));
            return Ok(_iMapper.Map<SaleItemsDto>(entidad));
        }

        [HttpPut]
        public async Task<ActionResult<SaleItemsDto>> ActualizarSaleItems(ActualizacionSaleItems dto)
        {
            var entidad = await _iServiceUnitOfWork.SaleItems.ActualizarSaleItems(_iMapper.Map<SaleItems>(dto));
            return Ok(_iMapper.Map<SaleItemsDto>(entidad));
        }

        [HttpDelete]
        public async Task<ActionResult<SaleItemsDto>> EliminarSaleItems(int id)
        {
            var entidad = await _iServiceUnitOfWork.SaleItems.EliminarSaleItems(id);
            return Ok(_iMapper.Map<SaleItemsDto>(entidad));
        }
    }
}
