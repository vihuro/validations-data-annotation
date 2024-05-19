using DataAnnotations.Application.Dtos;
using DataAnnotations.Application.Dtos.User;

namespace DataAnnotations.Application.Interface
{
    public interface IUserService
    {
        Task<GetUserDto> Insert(CreateUserDto request, CancellationToken cancellationToken);
    }
}
