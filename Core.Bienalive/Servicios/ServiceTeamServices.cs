
using Core.Bienalive.Entidades;
using Core.Bienalive.EntidadesPersonalizadas.TeamServices;
using Core.Bienalive.Interface;
using Core.Bienalive.Interface.Repositorio;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Utilitarios.Extenciones;

namespace Core.Bienalive.Servicios
{
    public class ServiceTeamServices : IDLTeamServices
    {
        private readonly IDLUnitOfWork _iDLUnitOfWork;

        public ServiceTeamServices(IDLUnitOfWork iDLUnitOfWork)
        {
            _iDLUnitOfWork = iDLUnitOfWork;
        }

        public async Task<IEnumerable<TeamServices>> ConsultarTeamServices(BusquedaTeamServices parametrosBusqueda)
        {
            Expression<Func<TeamServices, bool>> filtro = parametrosBusqueda.CrearFiltro<TeamServices>();
            return await _iDLUnitOfWork.DLTeamServices.ConsultarLista(filtro);
        }

        public async Task<TeamServices> CrearTeamServices(TeamServices entidad)
        {
            await _iDLUnitOfWork.DLTeamServices.Adicionar(entidad);
            await _iDLUnitOfWork.SaveChangesAsync();
            return entidad;
        }

        public async Task<TeamServices> ActualizarTeamServices(TeamServices entidad)
        {
            var registroDB = await _iDLUnitOfWork.DLTeamServices.ConsultarPorId(entidad.Id)
                ?? throw new ValidationException($"The TeamServices with ID {entidad.Id} does not exist.");

            _iDLUnitOfWork.DLTeamServices.Actualizar(registroDB);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }

        public async Task<TeamServices> EliminarTeamServices(long id)
        {
            var registroDB = await _iDLUnitOfWork.DLTeamServices.ConsultarPorId(id)
                ?? throw new ValidationException($"The TeamServices with ID {id} does not exist.");

            await _iDLUnitOfWork.DLTeamServices.Eliminar(id);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }
    }
}
