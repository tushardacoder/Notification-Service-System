// See https://aka.ms/new-console-template for more information

using Notification_System;

Console.WriteLine("Notification Service System");

Console.WriteLine("Press 1 -> Sign UP");
Console.WriteLine("Press 2 -> Pay Bill");
Console.WriteLine("Press 3 -> Order shipped");
Console.WriteLine("Press -> Any other key to sign out");

NotificationService notification = new NotificationService();

while (true)
{
    Console.WriteLine("Enter Your Input");
    var option = int.Parse(Console.ReadLine());

    if (option == 1)
    {
        notification.Inapp += msg => Console.WriteLine("Welcome in-app notification!\n"+msg);
        notification.Onemail += msg => Console.WriteLine("You recieved an email! \n" + msg);

        var action = Useractions.UserRegistration();
         notification.sendInapp(action);
         notification.sendemdil(action);
     

    }

    else if (option == 2)
    {
        notification.Onsms += msg => Console.WriteLine("You received a sms!\n" + msg);

        var action = Useractions.payment();

        notification.sendsms(action);


    }


    else if (option == 3)
    {
        notification.Inapp += msg => Console.WriteLine("Welcome in-app notification!\n" + msg);
        notification.Onemail += msg => Console.WriteLine("You recieved an email! \n" + msg);
        notification.Onsms += msg => Console.WriteLine("You received a sms!\n" + msg);

        var action =Useractions.ordershipment();
        notification.sendInapp(action);
        notification.sendemdil(action);
        notification.sendsms(action);

    }

    else
    {
        break;
    }

}
