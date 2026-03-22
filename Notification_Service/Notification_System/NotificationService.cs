using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification_System
{
    public delegate void notify(string message);
    public class NotificationService
    {
        public event notify Inapp;
        public event notify Onsms;
        public event notify Onemail;


        public void sendInapp(string message)
        {
               Inapp?.Invoke(message);
        }


        public void sendsms(string message)
        {
            Onsms?.Invoke(message);
        }

        public void sendemdil(string message)
        {

            Onemail?.Invoke(message);
        }
    }
}
