using DataAnnotations.Domain.Aux.Utils;

namespace DataAnnotations.Domain.Aux.Interface
{
    public interface INotification
    {
        bool HaveNotification();
        List<Notification> GetNotifications();
        void Handle(Notification notification);
        void ClearNotification();
    }
}
