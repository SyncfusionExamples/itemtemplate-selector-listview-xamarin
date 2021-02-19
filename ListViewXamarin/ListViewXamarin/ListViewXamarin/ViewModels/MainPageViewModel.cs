using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace DataTemplateSelector
{
    public class MainPageViewModel
    {

        private ObservableCollection<Message> messagesList;

        public ObservableCollection<Message> Messages
        {
            get { return messagesList; }
            set { messagesList = value; }
        }

        private string outgoingText;

        public string OutGoingText
        {
            get { return outgoingText; }
            set { outgoingText = value; }
        }
        
        public MainPageViewModel()
        {
              // Initialize with default values
            Messages = new ObservableCollection<Message>
            {
                new Message { Text = "Hi Jack.  What are you doing?", IsIncoming = true, MessagDateTime = DateTime.Now.AddMinutes(-25)},
                new Message { Text = "Hi Mary.  I'm filling out a job application.", IsIncoming = false, MessagDateTime = DateTime.Now.AddMinutes(-24)},
                new Message { Text = "Are you finished with school already?", IsIncoming = true, MessagDateTime = DateTime.Now.AddMinutes(-23)},
                new Message { Text = "No.  I have one more semester, but it would be great to have a job lined up.", IsIncoming = false, MessagDateTime = DateTime.Now.AddMinutes(-22)},
                new Message { Text = "How is your day going?", IsIncoming = true, MessagDateTime = DateTime.Now.AddMinutes(-21)},
                new Message { Text = "Quite busy.  I'm preparing for my exam tomorrow.", IsIncoming = false, MessagDateTime = DateTime.Now.AddMinutes(-20)},
                new Message { Text = "Good luck !.. for your exam.", IsIncoming = true, MessagDateTime = DateTime.Now.AddMinutes(-19)},
                new Message { Text = "Thank you buddy...Have a nice day", IsIncoming = false, MessagDateTime = DateTime.Now.AddMinutes(-18)},
            };
        }
    }
}
