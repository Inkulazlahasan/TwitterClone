using System;

namespace TwitterClone.Domain.Entities
{
    internal interface INotifiable
    {
        void AddNotification(Guid notificationId);
    }
}
