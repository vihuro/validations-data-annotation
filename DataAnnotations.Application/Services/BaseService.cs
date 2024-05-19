using AutoMapper;
using DataAnnotations.Domain.Aux.Interface;
using DataAnnotations.Domain.Aux.Utils;
using DataAnnotations.Domain.Interface;
using DataAnnotations.Utils;

namespace DataAnnotations.Application.Services
{
    public abstract class BaseService
    {
        protected readonly INotification _notification;
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly Mapper _mapper;

        protected BaseService(INotification notification,
                              IUnitOfWork unitOfWork)
        {
            _notification = notification;
            _unitOfWork = unitOfWork;
        }

        protected bool IsValidOperation()
        {
            return !_notification.HaveNotification();
        }
        protected void Notify(string message)
        {
            _notification.Handle(new Notification(message));
        }
        protected void EntityIsValid<T>(T entity)
        {
            if (!entity.IsValid())
            {
                var errors = entity.GetValidationErros();
                foreach (var item in errors)
                {
                    Notify($"{item.MemberNames.FirstOrDefault()} - {item.ErrorMessage}");
                }
            }
        }
    }
}
