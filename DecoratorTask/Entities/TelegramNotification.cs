using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTask.Entities
{
    public class TelegramNotification : NotificationDecarator
    {
        public TelegramNotification(INotification notification) : base(notification)
        {
        }
        public override Item GetNotification()
        {
            var item = new Item("Telegram Notification","Images\\telegram_64.png");
            return item;
        }
    }
}
