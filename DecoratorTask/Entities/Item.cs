using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorTask.Entities
{
    public class Item
    {
        public Item()
        {

        }
        public Item(string message,string imagePath)
        {

            Message = message;
            ImagePath = imagePath;
        }
        public string Message { get; set; }
        public string ImagePath { get; set; }
    }

}
