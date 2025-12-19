namespace Core.Bienalive.Dto.Auth
{
    public class LoginResponseDto
    {
        /// <value>Token JWT.</value>
        public string Token { get; set; } = string.Empty;

        /// <value>Fecha de expiración UTC.</value>
        public DateTime ExpiresAtUtc { get; set; }

        /// <value>Rol del usuario.</value>
        public string Role { get; set; } = string.Empty;
    }
}
