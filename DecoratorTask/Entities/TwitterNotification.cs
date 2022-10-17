using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTask.Entities
{
    public class TwitterNotification : NotificationDecarator
    {
        public TwitterNotification(INotification notification) : base(notification)
        {
        }
        public override Item GetNotification()
        {
            var item = new Item("Twitter Notification", "Images\\icons8_twitter_64.png");
            return item;
        }
    }
}
