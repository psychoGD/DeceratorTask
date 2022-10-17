using DecoratorTask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DecoratorTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            INotification notification = new Notification();
            NotificationDecarator notificationDecarator = new NotificationDecarator(notification);
            
            foreach (var item in CheckBoxesSP.Children)
            {
                var item2 = (CheckBox)item;
                if (item2.IsChecked == true)
                {
                    if(item2.Content.ToString() == "Telegram")
                    {
                        INotification Telegramnotification = new TelegramNotification(notificationDecarator);
                    }
                    else if(item2.Content.ToString() == "Instagram")
                    {
                        INotification Instagramnotification = new InstagramNotification(notificationDecarator);
                    }
                    else if(item2.Content.ToString() == "Twitter")
                    {
                        INotification Twitternotification = new TwitterNotification(notificationDecarator);
                    }
                }
            }
            MessageBox.Show(notificationDecarator.GetNotification())
        }
    }
}
