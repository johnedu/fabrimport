using Abp.Notifications;
using Project.Dto;

namespace Project.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}