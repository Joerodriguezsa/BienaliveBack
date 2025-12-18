
using Core.Bienalive.Entidades;
using Core.Bienalive.EntidadesPersonalizadas.Users;
using Core.Bienalive.Interface;
using Core.Bienalive.Interface.Repositorio;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Utilitarios.Extenciones;

namespace Core.Bienalive.Servicios
{
    public class ServiceUsers : IDLUsers
    {
        private readonly IDLUnitOfWork _iDLUnitOfWork;

        public ServiceUsers(IDLUnitOfWork iDLUnitOfWork)
        {
            _iDLUnitOfWork = iDLUnitOfWork;
        }

        public async Task<IEnumerable<Users>> ConsultarUsers(BusquedaUsers parametrosBusqueda)
        {
            Expression<Func<Users, bool>> filtro = parametrosBusqueda.CrearFiltro<Users>();
            return await _iDLUnitOfWork.DLUsers.ConsultarLista(filtro);
        }

        public async Task<Users> CrearUsers(Users entidad)
        {
            await _iDLUnitOfWork.DLUsers.Adicionar(entidad);
            await _iDLUnitOfWork.SaveChangesAsync();
            return entidad;
        }

        public async Task<Users> ActualizarUsers(Users entidad)
        {
            var registroDB = await _iDLUnitOfWork.DLUsers.ConsultarPorId(entidad.Id)
                ?? throw new ValidationException($"The Users with ID {entidad.Id} does not exist.");

            _iDLUnitOfWork.DLUsers.Actualizar(registroDB);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }

        public async Task<Users> EliminarUsers(int id)
        {
            var registroDB = await _iDLUnitOfWork.DLUsers.ConsultarPorId(id)
                ?? throw new ValidationException($"The Users with ID {id} does not exist.");

            await _iDLUnitOfWork.DLUsers.Eliminar(id);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }
    }
}
