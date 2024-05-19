using DataAnnotations.Application.Dtos;
using DataAnnotations.Domain.Aux.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DataAnnotations.Api.Controllers
{
    public class BaseController : ControllerBase
    {
        private readonly INotification _notification;
        protected BaseController(INotification notification)
        {
            _notification = notification;
        }
        protected ActionResult InsertEntityResponse<T>(T entity)
        {
            if (IsValidOperation())
            {
                return Ok(new BaseReturn
                {
                    Success = true,
                    Results = entity
                });
            }
            return CustomResponseError();
        }
        protected ActionResult CustomResponseError()
        {
            return BadRequest(new BaseReturn()
            {
                Success = false,
                Errors = _notification.GetNotifications().Select(x => x.Message)
            });
        }
        protected bool IsValidOperation()
        {
            return !_notification.HaveNotification();
        }
    }
}
