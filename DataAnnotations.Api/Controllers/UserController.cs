using DataAnnotations.Application.Dtos;
using DataAnnotations.Application.Dtos.User;
using DataAnnotations.Application.Interface;
using DataAnnotations.Domain.Aux.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DataAnnotations.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UserController : BaseController
    {
        private readonly IUserService _userService;
        public UserController(INotification notification,
                              IUserService userService) : base(notification)
        {
            _userService = userService;
        }
        [HttpPost]
        public async Task<ActionResult<BaseReturnApresentations<GetUserDto>>> Insert(CreateUserDto request,
                                                                       CancellationToken cancellationToken)
        {
            var result = await _userService.Insert(request, cancellationToken);
            return InsertEntityResponse(result);
        }
    }
}
