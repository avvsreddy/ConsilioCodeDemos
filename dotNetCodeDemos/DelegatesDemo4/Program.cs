using System.Net.Mail;

namespace DelegatesDemo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account();
            acc1.notify += Notification.SendEmail;//subscription
            acc1.notify += Notification.SendSMS;
            acc1.notify -= Notification.SendSMS;
            acc1.notify += Notification.SendWhatsApp;
            acc1.Deposit(5000);
            Console.WriteLine(acc1.Balance);
            //acc1.Withdraw(1000);
            Console.WriteLine(acc1.Balance);
        }
    }
    // Step 1: delegate declaration
    public delegate void NotifyDelegate(string msg);
    class Account
    {
        public int Balance { get; private set; }
        public NotifyDelegate notify = null;// new NotifyDelegate(Notification.SendSMS);
       
        public void Deposit(int amount)
        {
            Balance += amount;
            // write code here to send email
            //Notification.SendEmail($"Your account increased by {amount}");
            //Notification.SendSMS($"Your account increased by {amount}");
            if (notify != null)
            {
                notify($"Your account increased by {amount}");
            }


        }
        public void Withdraw(int amount)
        { 
            Balance -= amount;
            // write code here to send email
            //Notification.SendEmail($"Your account decreased by {amount}");
            //Notification.SendSMS($"Your account decreased by {amount}");
            if (notify != null)
            {
                notify($"Your account decreased by {amount}");
            }
        }
    }

    class Notification
    {
        public static void SendEmail(string msg)
        {
            //SmtpClient smtp = new SmtpClient();
            ////smtp.Host = "localhost";
            //MailMessage mailMessage = new MailMessage();
            ////mailMessage.From = "";

            //smtp.Send(mailMessage);
            Console.WriteLine("Email: " + msg);
        }

        public static void SendSMS(string msg) { Console.WriteLine("SMS: " + msg); }
        public static void SendWhatsApp(string msg) { Console.WriteLine("Whats App: " + msg); }
    }
}
