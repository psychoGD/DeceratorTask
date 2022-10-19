using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTask.Entities
{
    public class NotificationDecarator : INotification
    {
        private INotification notification;

        public NotificationDecarator(INotification notification)
        {
            this.notification = notification;
        }

        public virtual Item GetNotification()
        {
            return notification.GetNotification();
        }
        
    }
}
