
namespace Api.Bienalive.Controllers
{
    using AutoMapper;
    using Core.Bienalive.Interface;
    using Core.Bienalive.Dto.ProductImages;
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.ProductImages;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class ProductImagesController : ControllerBase
    {
        private readonly IServiceUnitOfWork _iServiceUnitOfWork;
        private readonly IMapper _iMapper;

        public ProductImagesController(IMapper iMapper, IServiceUnitOfWork iServiceUnitOfWork)
        {
            _iMapper = iMapper;
            _iServiceUnitOfWork = iServiceUnitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductImagesDto>>> ConsultarProductImages([FromQuery] BusquedaProductImages filtros)
        {
            var data = await _iServiceUnitOfWork.ProductImages.ConsultarProductImages(_iMapper.Map<BusquedaProductImages>(filtros));
            return Ok(_iMapper.Map<List<ProductImagesDto>>(data));
        }

        [HttpPost]
        public async Task<ActionResult<ProductImagesDto>> CrearProductImages(CreacionProductImages dto)
        {
            var entidad = await _iServiceUnitOfWork.ProductImages.CrearProductImages(_iMapper.Map<ProductImages>(dto));
            return Ok(_iMapper.Map<ProductImagesDto>(entidad));
        }

        [HttpPut]
        public async Task<ActionResult<ProductImagesDto>> ActualizarProductImages(ActualizacionProductImages dto)
        {
            var entidad = await _iServiceUnitOfWork.ProductImages.ActualizarProductImages(_iMapper.Map<ProductImages>(dto));
            return Ok(_iMapper.Map<ProductImagesDto>(entidad));
        }

        [HttpDelete]
        public async Task<ActionResult<ProductImagesDto>> EliminarProductImages(int id)
        {
            var entidad = await _iServiceUnitOfWork.ProductImages.EliminarProductImages(id);
            return Ok(_iMapper.Map<ProductImagesDto>(entidad));
        }
    }
}
