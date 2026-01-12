
namespace Api.Bienalive.Controllers
{
    using AutoMapper;
    using Core.Bienalive.Dto.EmployeeServices;
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.EmployeeServices;
    using Core.Bienalive.Interface;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeServicesController : ControllerBase
    {
        private readonly IServiceUnitOfWork _iServiceUnitOfWork;
        private readonly IMapper _iMapper;

        public EmployeeServicesController(IMapper iMapper, IServiceUnitOfWork iServiceUnitOfWork)
        {
            _iMapper = iMapper;
            _iServiceUnitOfWork = iServiceUnitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeServicesDto>>> ConsultarEmployeeServices([FromQuery] BusquedaEmployeeServices filtros)
        {
            var data = await _iServiceUnitOfWork.EmployeeServices.ConsultarEmployeeServices(_iMapper.Map<BusquedaEmployeeServices>(filtros));
            return Ok(_iMapper.Map<List<EmployeeServicesDto>>(data));
        }

        [HttpPost]
        public async Task<ActionResult<EmployeeServicesDto>> CrearEmployeeServices(CreacionEmployeeServices dto)
        {
            var entidad = await _iServiceUnitOfWork.EmployeeServices.CrearEmployeeServices(_iMapper.Map<EmployeeServices>(dto));
            return Ok(_iMapper.Map<EmployeeServicesDto>(entidad));
        }

        [HttpPut]
        public async Task<ActionResult<EmployeeServicesDto>> ActualizarEmployeeServices(ActualizacionEmployeeServices dto)
        {
            var entidad = await _iServiceUnitOfWork.EmployeeServices.ActualizarEmployeeServices(_iMapper.Map<EmployeeServices>(dto));
            return Ok(_iMapper.Map<EmployeeServicesDto>(entidad));
        }

        [HttpDelete]
        public async Task<ActionResult<EmployeeServicesDto>> EliminarEmployeeServices(int id)
        {
            var entidad = await _iServiceUnitOfWork.EmployeeServices.EliminarEmployeeServices(id);
            return Ok(_iMapper.Map<EmployeeServicesDto>(entidad));
        }
    }
}
