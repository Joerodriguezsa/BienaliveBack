namespace Api.Bienalive.Controllers
{
    using Api.Bienalive.Services;
    using Core.Bienalive.Dto.Auth;
    using Core.Bienalive.Dto.Customers;
    using Core.Bienalive.Dto.Users;
    using Core.Bienalive.Entidades;
    using Core.Bienalive.EntidadesPersonalizadas.Roles;
    using Core.Bienalive.EntidadesPersonalizadas.Users;
    using Core.Bienalive.Interface;
    using Microsoft.AspNetCore.Mvc;
    using System.Security.Cryptography;

    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IServiceUnitOfWork _serviceUnitOfWork;
        private readonly JwtTokenService _jwtTokenService;

        public AuthController(
            IServiceUnitOfWork serviceUnitOfWork,
            JwtTokenService jwtTokenService)
        {
            _serviceUnitOfWork = serviceUnitOfWork;
            _jwtTokenService = jwtTokenService;
        }

        /// <summary>Autentica un usuario y genera un JWT.</summary>
        [HttpPost("login")]
        public async Task<ActionResult<LoginResponseDto>> Login(LoginRequestDto request)
        {
            // 1️⃣ Buscar usuario por Email
            var usuarios = await _serviceUnitOfWork.Users.ConsultarUsers(
                new BusquedaUsers
                {
                    Email = request.Email
                });

            Users? usuario = usuarios.FirstOrDefault();
            if (usuario == null)
                return Unauthorized("Invalid Email or no exists.");

            // 2️⃣ Validar contraseña (texto plano por ahora)
            if (!VerifyPassword(request.Password, usuario.Password))
                return Unauthorized("Invalid password.");

            // 3️⃣ Obtener rol
            string roleName = "User";

            if (usuario.RoleId.HasValue)
            {
                var roles = await _serviceUnitOfWork.ServicesRoles.ConsultarRoles(
                    new BusquedaRoles { Id = usuario.RoleId.Value });

                roleName = roles.FirstOrDefault()?.Name ?? "User";
            }

            // 4️⃣ Generar token
            var (token, expires) = _jwtTokenService.CreateToken(
                usuario.Id,
                usuario.Email,
                roleName
            );

            return Ok(new LoginResponseDto
            {
                Token = token,
                ExpiresAtUtc = expires,
                RoleId = usuario.RoleId,
                Role = roleName,
                UserId = usuario.Id,
                Name = usuario.Name,
                Email = usuario.Email
            });
        }

        /// <summary>Registra un customer y un user en una sola transacción.</summary>
        [HttpPost("registercustomer")]
        public async Task<ActionResult<RegisterCustomerResponseDto>> RegisterCustomer(RegisterCustomerRequestDto request)
        {
            var result = await _serviceUnitOfWork.ExecuteInTransactionAsync(async () =>
            {
                var user = await _serviceUnitOfWork.Users.CrearUsers(new Users
                {
                    Name = request.Name,
                    Email = request.Email,
                    Password = request.Password,
                    RoleId = request.RoleId,
                    Active = request.Active
                });

                var customer = await _serviceUnitOfWork.Customers.CrearCustomers(new Customers
                {
                    Name = request.Name,
                    UserId = user.Id,
                    Email = request.Email,
                    Phone = request.Phone,
                    DateOfBirth = request.DateOfBirth,
                    Address = request.Address
                });

                return new RegisterCustomerResponseDto
                {
                    User = new UsersDto
                    {
                        Id = user.Id,
                        Name = user.Name,
                        Email = user.Email,
                        RoleId = user.RoleId,
                        Active = user.Active
                    },
                    Customer = new CustomersDto
                    {
                        Id = customer.Id,
                        UserId = customer.UserId,
                        Name = customer.Name,
                        Email = customer.Email,
                        Phone = customer.Phone,
                        DateOfBirth = customer.DateOfBirth,
                        Address = customer.Address
                    }
                };
            });

            return Ok(result);
        }

        #region Password Security (Controller-local)

        private const int KeySize = 32;

        private bool VerifyPassword(string password, string hash)
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
