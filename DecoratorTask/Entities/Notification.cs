using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTask.Entities
{
    public class Notification : INotification
    {
        public Item GetNotification()
        {
            return new Item();
        }
    }
}
