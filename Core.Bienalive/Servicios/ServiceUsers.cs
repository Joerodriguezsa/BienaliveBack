
using Core.Bienalive.Entidades;
using Core.Bienalive.EntidadesPersonalizadas.Users;
using Core.Bienalive.Interface;
using Core.Bienalive.Interface.Repositorio;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Security.Cryptography;
using Utilitarios.Extenciones;

namespace Core.Bienalive.Servicios
{
    public class ServiceUsers : IDLUsers
    {
        private readonly IDLUnitOfWork _iDLUnitOfWork;

        private const int SaltSize = 16;
        private const int KeySize = 32;
        private const int Iterations = 100_000;

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
            try
            {
                if (string.IsNullOrWhiteSpace(entidad.Email))
                    throw new ValidationException("Email is required.");

                if (string.IsNullOrWhiteSpace(entidad.Password))
                    throw new ValidationException("Password is required.");

                var usuariosConMismoCorreo = await _iDLUnitOfWork.DLUsers.ConsultarLista(u => u.Email == entidad.Email);

                if (usuariosConMismoCorreo.Any())
                    throw new ValidationException("The email is already registered.");

                entidad.Password = HashPassword(entidad.Password);

                await _iDLUnitOfWork.DLUsers.Adicionar(entidad);
                await _iDLUnitOfWork.SaveChangesAsync();
                return entidad;
            }
            catch (Exception ex)
            {
                throw;
            }            
        }

        public async Task<Users> ActualizarUsers(Users entidad)
        {
            var registroDB = await _iDLUnitOfWork.DLUsers.ConsultarPorId(entidad.Id)
                ?? throw new ValidationException($"The Users with ID {entidad.Id} does not exist.");

            registroDB.Name = entidad.Name;
            registroDB.Email = entidad.Email;
            registroDB.RoleId = entidad.RoleId;
            registroDB.Active = entidad.Active;

            // Si viene password, se vuelve a hashear
            if (!string.IsNullOrWhiteSpace(entidad.Password))
            {
                registroDB.Password = HashPassword(entidad.Password);
            }

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

        #region Password Security (PRIVATE)

        private string HashPassword(string password)
        {
            using var algorithm = new Rfc2898DeriveBytes(
                password,
                SaltSize,
                Iterations,
                HashAlgorithmName.SHA256
            );

            var salt = algorithm.Salt;
            var key = algorithm.GetBytes(KeySize);

            return $"{Iterations}.{Convert.ToBase64String(salt)}.{Convert.ToBase64String(key)}";
        }

        public bool VerifyPassword(string password, string hash)
        {
            var parts = hash.Split('.', 3);
            if (parts.Length != 3)
                return false;

            var iterations = int.Parse(parts[0]);
            var salt = Convert.FromBase64String(parts[1]);
            var key = Convert.FromBase64String(parts[2]);

            using var algorithm = new Rfc2898DeriveBytes(
                password,
                salt,
                iterations,
                HashAlgorithmName.SHA256
            );

            var keyToCheck = algorithm.GetBytes(KeySize);
            return CryptographicOperations.FixedTimeEquals(keyToCheck, key);
        }

        #endregion
    }
}
