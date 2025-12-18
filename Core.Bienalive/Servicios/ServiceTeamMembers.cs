
using Core.Bienalive.Entidades;
using Core.Bienalive.EntidadesPersonalizadas.TeamMembers;
using Core.Bienalive.Interface;
using Core.Bienalive.Interface.Repositorio;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Utilitarios.Extenciones;

namespace Core.Bienalive.Servicios
{
    public class ServiceTeamMembers : IDLTeamMembers
    {
        private readonly IDLUnitOfWork _iDLUnitOfWork;

        public ServiceTeamMembers(IDLUnitOfWork iDLUnitOfWork)
        {
            _iDLUnitOfWork = iDLUnitOfWork;
        }

        public async Task<IEnumerable<TeamMembers>> ConsultarTeamMembers(BusquedaTeamMembers parametrosBusqueda)
        {
            Expression<Func<TeamMembers, bool>> filtro = parametrosBusqueda.CrearFiltro<TeamMembers>();
            return await _iDLUnitOfWork.DLTeamMembers.ConsultarLista(filtro);
        }

        public async Task<TeamMembers> CrearTeamMembers(TeamMembers entidad)
        {
            await _iDLUnitOfWork.DLTeamMembers.Adicionar(entidad);
            await _iDLUnitOfWork.SaveChangesAsync();
            return entidad;
        }

        public async Task<TeamMembers> ActualizarTeamMembers(TeamMembers entidad)
        {
            var registroDB = await _iDLUnitOfWork.DLTeamMembers.ConsultarPorId(entidad.Id)
                ?? throw new ValidationException($"The TeamMembers with ID {entidad.Id} does not exist.");

            _iDLUnitOfWork.DLTeamMembers.Actualizar(registroDB);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }

        public async Task<TeamMembers> EliminarTeamMembers(int id)
        {
            var registroDB = await _iDLUnitOfWork.DLTeamMembers.ConsultarPorId(id)
                ?? throw new ValidationException($"The TeamMembers with ID {id} does not exist.");

            await _iDLUnitOfWork.DLTeamMembers.Eliminar(id);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }
    }
}
