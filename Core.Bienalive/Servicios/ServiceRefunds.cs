
using Core.Bienalive.Entidades;
using Core.Bienalive.EntidadesPersonalizadas.Refunds;
using Core.Bienalive.Interface;
using Core.Bienalive.Interface.Repositorio;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Utilitarios.Extenciones;

namespace Core.Bienalive.Servicios
{
    public class ServiceRefunds : IDLRefunds
    {
        private readonly IDLUnitOfWork _iDLUnitOfWork;

        public ServiceRefunds(IDLUnitOfWork iDLUnitOfWork)
        {
            _iDLUnitOfWork = iDLUnitOfWork;
        }

        public async Task<IEnumerable<Refunds>> ConsultarRefunds(BusquedaRefunds parametrosBusqueda)
        {
            Expression<Func<Refunds, bool>> filtro = parametrosBusqueda.CrearFiltro<Refunds>();
            return await _iDLUnitOfWork.DLRefunds.ConsultarLista(filtro);
        }

        public async Task<Refunds> CrearRefunds(Refunds entidad)
        {
            await _iDLUnitOfWork.DLRefunds.Adicionar(entidad);
            await _iDLUnitOfWork.SaveChangesAsync();
            return entidad;
        }

        public async Task<Refunds> ActualizarRefunds(Refunds entidad)
        {
            var registroDB = await _iDLUnitOfWork.DLRefunds.ConsultarPorId(entidad.Id)
                ?? throw new ValidationException($"The Refunds with ID {entidad.Id} does not exist.");

            _iDLUnitOfWork.DLRefunds.Actualizar(registroDB);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }

        public async Task<Refunds> EliminarRefunds(int id)
        {
            var registroDB = await _iDLUnitOfWork.DLRefunds.ConsultarPorId(id)
                ?? throw new ValidationException($"The Refunds with ID {id} does not exist.");

            await _iDLUnitOfWork.DLRefunds.Eliminar(id);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }
    }
}
