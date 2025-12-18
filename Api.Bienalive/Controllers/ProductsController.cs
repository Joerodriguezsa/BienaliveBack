
namespace Api.Bienalive.Controllers
{
    using AutoMapper;
    using Core.Bienalive.Interface;
    using Core.Bienalive.Dto.Products;
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.Products;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IServiceUnitOfWork _iServiceUnitOfWork;
        private readonly IMapper _iMapper;

        public ProductsController(IMapper iMapper, IServiceUnitOfWork iServiceUnitOfWork)
        {
            _iMapper = iMapper;
            _iServiceUnitOfWork = iServiceUnitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductsDto>>> ConsultarProducts([FromQuery] BusquedaProducts filtros)
        {
            var data = await _iServiceUnitOfWork.Products.ConsultarProducts(_iMapper.Map<BusquedaProducts>(filtros));
            return Ok(_iMapper.Map<List<ProductsDto>>(data));
        }

        [HttpPost]
        public async Task<ActionResult<ProductsDto>> CrearProducts(CreacionProducts dto)
        {
            var entidad = await _iServiceUnitOfWork.Products.CrearProducts(_iMapper.Map<Products>(dto));
            return Ok(_iMapper.Map<ProductsDto>(entidad));
        }

        [HttpPut]
        public async Task<ActionResult<ProductsDto>> ActualizarProducts(ActualizacionProducts dto)
        {
            var entidad = await _iServiceUnitOfWork.Products.ActualizarProducts(_iMapper.Map<Products>(dto));
            return Ok(_iMapper.Map<ProductsDto>(entidad));
        }

        [HttpDelete]
        public async Task<ActionResult<ProductsDto>> EliminarProducts(int id)
        {
            var entidad = await _iServiceUnitOfWork.Products.EliminarProducts(id);
            return Ok(_iMapper.Map<ProductsDto>(entidad));
        }
    }
}
