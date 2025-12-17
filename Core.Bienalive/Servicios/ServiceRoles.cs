using Core.Bienalive.Dto.Roles;
using Core.Bienalive.Entidades;
using Core.Bienalive.EntidadesPersonalizadas.Roles;
using Core.Bienalive.Interface;
using Core.Bienalive.Interface.Repositorio;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using Utilitarios.Extenciones;

namespace Core.Bienalive.Servicios
{
    public class ServiceRoles : IDLRoles
    {
        #region Variables

        /// <summary>Instancia de la unidad de trabajo - DLUnitOfWork.</summary>
        private readonly IDLUnitOfWork _iDLUnitOfWork;
        private List<string> errores = new List<string>();

        #endregion

        #region Constructor

        ///<summary>Inicializa una nueva instancia de la clase SolesService.</summary>
        /// <param name="iDLUnitOfWork">Inyeccion de dependencias de la unidad de trabajo - DLUnitOfWork.</param>
        public ServiceRoles(IDLUnitOfWork iDLUnitOfWork)
        {
            _iDLUnitOfWork = iDLUnitOfWork;
        }

        #endregion

        #region Metodos

        /// <summary>Consulta la Soles.</summary>
        /// <param name="parametrosBusqueda">Parametros de entrada para la consulta.</param>
        /// <returns>Lista de Soless consultadas.</returns>
        public async Task<IEnumerable<Roles>> ConsultarRoles(BusquedaRoles parametrosBusqueda)
        {
            Expression<Func<Roles, bool>> filtro = parametrosBusqueda.CrearFiltro<Roles>();
            return await _iDLUnitOfWork.DLRoles.ConsultarLista(filtro);
        }

        public async Task<IEnumerable<RolesDto>> ConsultarRolesWithImages(BusquedaRoles parametrosBusqueda)
        {
            Expression<Func<Entidades.Roles, bool>> filtro = parametrosBusqueda.CrearFiltro<Entidades.Roles>();
            var servicios = await _iDLUnitOfWork.DLRoles.ConsultarLista(filtro);

            var ids = servicios.Select(s => s.Id).ToList();

            var imagenes = await _iDLUnitOfWork.DLServiceImages.ConsultarLista(img => ids.Contains(img.ServiceId));

            var imagenesPorServicio = imagenes
                .GroupBy(img => img.ServiceId)
                .ToDictionary(g => g.Key, g => g.ToList());

            var resultado = servicios.Select(s => new RolesDto
            {
                Id = s.Id,
                Name = s.Name                
            });

            return resultado;
        }

        /// <summary>Crea la entidad Soles.</summary>
        /// <param name="Soles">Parametros de entrada para la creacion.</param>
        /// <returns>Entidad Soles.</returns>
        public async Task<Roles> CrearRoles(Roles Roles)
        {
            await ValidarRoles(Roles);
            // Verificar que los valores requeridos no sean nulos.
            await _iDLUnitOfWork.DLRoles.Adicionar(Roles);
            await _iDLUnitOfWork.SaveChangesAsync();
            return Roles;
        }

        /// <summary>Actualiza la Soles.</summary>
        /// <param name="Soles">Parametros de entrada para la actualizacion de la Soles.</param>
        /// <returns>Entidad Soles Actualizada.</returns>
        public async Task<Entidades.Roles> ActualizarRoles(Entidades.Roles Roles)
        {
            Entidades.Roles registroDB = await _iDLUnitOfWork.DLRoles.ConsultarPorId(Roles.Id)
                ?? throw new ValidationException($"The Roles with ID {Roles.Id} does not exist.");

            registroDB.Name = Roles.Name ?? registroDB.Name;

            await ValidarRoles(registroDB);

            _iDLUnitOfWork.DLRoles.Actualizar(registroDB);

            await _iDLUnitOfWork.SaveChangesAsync();

            return registroDB;
        }

        /// <summary>Elimina la Soles.</summary>
        /// <param name="SolesId">Parametro de entrada para la Eliminacion de la Soles.</param>
        /// <returns>Entidad Soles Eliminada.</returns>
        public async Task<Entidades.Roles> EliminarRoles(int SolesId)
        {

            Entidades.Roles registroDB = await _iDLUnitOfWork.DLRoles.ConsultarPorId(SolesId)
                ?? throw new ValidationException($"La Soles con ID {SolesId} no existe.");

            await _iDLUnitOfWork.DLRoles.Eliminar(SolesId);
            await _iDLUnitOfWork.SaveChangesAsync();
            return registroDB;
        }

        #endregion

        #region Validaciones

        /// <summary>Valida los Parametros de Soles.</summary>
        /// <param name="Soles">Parametro de entrada para la validacion.</param>
        /// <returns>Este metodo no retorna ningún valor.</returns>
        private async Task ValidarRoles(Entidades.Roles Roles)
        {

            //if (Soles.SolesPrioridad <= 0)
            //    errores.Add("SolesPrioridad debe ser mayor a 0.");

            if (string.IsNullOrWhiteSpace(Roles.Name))
                errores.Add("The name of the Roles cannot be null or empty.");

            if (errores.Any())
                throw new ValidationException(string.Join(" | ", errores));
        }

        #endregion
    }
}
