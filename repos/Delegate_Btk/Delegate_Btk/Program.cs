using System;

namespace Delegate_Btk
{
    public delegate void MyDelegate();
    public delegate void MyDelegate2(string text);
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.SendMessage();
            customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.ShowAlert; //Görevini yerine getirmedi daha
            myDelegate += customerManager.SendMessage;
            myDelegate();

            MyDelegate2 myDelegate2 = customerManager.ShowAlert;
            myDelegate2("yasin");
            Console.ReadKey();
        }

        public class CustomerManager
        {
            public void SendMessage()
            {
                Console.WriteLine("Hello!");
            }

            public void ShowAlert() //Uyarı
            {
                Console.WriteLine("Be Careful!");
            }

            public void ShowAlert(string text)
            {
                Console.WriteLine(text);
            }
        }
    }
}
