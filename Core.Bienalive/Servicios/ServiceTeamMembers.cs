
using Core.Bienalive.Dto.TeamMembers;
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

        public async Task<IEnumerable<TeamMembersDto>> ConsultarTeamMembersComplete(BusquedaTeamMembers parametrosBusqueda)
        {
            Expression<Func<TeamMembers, bool>> filtro = parametrosBusqueda.CrearFiltro<TeamMembers>();

            var teamMembers = await _iDLUnitOfWork.DLTeamMembers.ConsultarLista(filtro);

            var userIds = teamMembers
                .Where(s => s.UserId.HasValue)
                .Select(s => s.UserId.Value)
                .Distinct()
                .ToList();

            var users = await _iDLUnitOfWork.DLUsers.ConsultarLista(u => userIds.Contains(u.Id));

            var resultado =
                from tm in teamMembers
                join u in users on tm.UserId equals u.Id into gj
                from user in gj.DefaultIfEmpty()
                select new TeamMembersDto
                {
                    Id = tm.Id,
                    Photo = tm.Photo,
                    UserId = tm.UserId,
                    Name = user?.Name ?? string.Empty,
                    Email = user?.Email ?? string.Empty,
                    RoleId = user?.RoleId
                };

            return resultado;
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
