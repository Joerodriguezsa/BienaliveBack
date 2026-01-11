namespace Core.Bienalive.Dto.Auth
{
    public class LoginRequestDto
    {
        /// <value>Usuario o correo electrónico.</value>
        public string Email { get; set; } = string.Empty;

        /// <value>Contraseña del usuario.</value>
        public string Password { get; set; } = string.Empty;
    }
}
