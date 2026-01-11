namespace Core.Bienalive.Dto.Auth
{
    public class RegisterCustomerRequestDto
    {
        public required string Name { get; set; }

        public required string Email { get; set; }

        public required string Password { get; set; }

        public long? RoleId { get; set; }

        public bool? Active { get; set; }

        public string? Phone { get; set; }

        public DateOnly? DateOfBirth { get; set; }

        public string? Address { get; set; }
    }
}
