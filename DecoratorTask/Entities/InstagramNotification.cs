using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTask.Entities
{
    public class InstagramNotification : NotificationDecarator
    {
        public InstagramNotification(INotification notification) : base(notification)
        {
        }
        public override Item GetNotification()
        {
            var item = new Item("Instagram Notification", "Images\\icons8_instagram_64.png");
            return item;
        }
    }
}
