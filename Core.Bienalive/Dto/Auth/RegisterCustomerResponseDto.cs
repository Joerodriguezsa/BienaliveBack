using Core.Bienalive.Dto.Customers;
using Core.Bienalive.Dto.Users;

namespace Core.Bienalive.Dto.Auth
{
    public class RegisterCustomerResponseDto
    {
        public required UsersDto User { get; set; }

        public required CustomersDto Customer { get; set; }
    }
}
