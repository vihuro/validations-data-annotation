using AutoMapper;
using DataAnnotations.Application.Dtos.User;
using DataAnnotations.Application.Interface;
using DataAnnotations.Domain.Aux.Interface;
using DataAnnotations.Domain.Interface;
using DataAnnotations.Domain.Models;

namespace DataAnnotations.Application.Services
{
    public class UserService : BaseService, IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(INotification notification,
                          IUnitOfWork unitOfWork,
                          IUserRepository userRepository,
                          IMapper mapper) :
                          base(notification, unitOfWork)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<GetUserDto> Insert(CreateUserDto request,
                                            CancellationToken cancellationToken)
        {

            var entity = _mapper.Map<UserModel>(request);

            EntityIsValid(entity);

            if (!IsValidOperation()) return null;

            _userRepository.Create(entity);

            await _unitOfWork.Commit(cancellationToken);

            var result = _mapper.Map<GetUserDto>(entity);

            return _mapper.Map<GetUserDto>(entity);
        }
    }
}
