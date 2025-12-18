
using Core.Bienalive.Entidades;
using Core.Bienalive.EntidadesPersonalizadas.Invoices;
using Core.Bienalive.Interface;
using Core.Bienalive.Interface.Repositorio;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Utilitarios.Extenciones;

namespace Core.Bienalive.Servicios
{
    public class ServiceInvoices : IDLInvoices
    {
        private readonly IDLUnitOfWork _iDLUnitOfWork;

        public ServiceInvoices(IDLUnitOfWork iDLUnitOfWork)
        {
            _iDLUnitOfWork = iDLUnitOfWork;
        }

        public async Task<IEnumerable<Invoices>> ConsultarInvoices(BusquedaInvoices parametrosBusqueda)
        {
            Expression<Func<Invoices, bool>> filtro = parametrosBusqueda.CrearFiltro<Invoices>();
            return await _iDLUnitOfWork.DLInvoices.ConsultarLista(filtro);
        }

        public async Task<Invoices> CrearInvoices(Invoices entidad)
        {
            await _iDLUnitOfWork.DLInvoices.Adicionar(entidad);
            await _iDLUnitOfWork.SaveChangesAsync();
            return entidad;
        }

        public async Task<Invoices> ActualizarInvoices(Invoices entidad)
        {
            var registroDB = await _iDLUnitOfWork.DLInvoices.ConsultarPorId(entidad.Id)
                ?? throw new ValidationException($"The Invoices with ID {entidad.Id} does not exist.");

            _iDLUnitOfWork.DLInvoices.Actualizar(registroDB);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }

        public async Task<Invoices> EliminarInvoices(int id)
        {
            var registroDB = await _iDLUnitOfWork.DLInvoices.ConsultarPorId(id)
                ?? throw new ValidationException($"The Invoices with ID {id} does not exist.");

            await _iDLUnitOfWork.DLInvoices.Eliminar(id);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }
    }
}
