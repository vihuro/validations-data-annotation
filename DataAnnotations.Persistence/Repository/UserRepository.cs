using DataAnnotations.Domain.Interface;
using DataAnnotations.Domain.Models;
using DataAnnotations.Persistence.Context;

namespace DataAnnotations.Persistence.Repository
{
    public class UserRepository : BaseRepository<UserModel>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        { }

    }
}
