using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // how to call singleton class

            //var ob = Singleton.GetInstance; 
            //ob.Method();

            // how to call factory class

            //Factory f = new Factory();
            //var ff = f.GetInstance(3);
            //var data = ff.ShowData();
            //foreach (var item in data)
            //{
            //    Console.WriteLine(item);
            //}

            //Circle obj = new Circle();
            //obj.Radius = 10;
            //obj.Color = "red";
            //obj.Draw();
            //Circle obj1 = new Circle();
            //obj1 = (Circle)obj.Clone();
            //obj1.Color = "blue";    
            //obj.Draw();
            //obj1.Draw();

            //IPrinter p = new ModernPrinter();
            //p.Print("Hello World");
            //LegacyPrinterAdapter lpa = new LegacyPrinterAdapter(new LegacyPrinter());  
            //lpa.Print("Hello World");   

            //Login l = new Login();  
            //l.checkuser();

            //Product p = new Product();
            //p.addproduct();

            //MakePayment mp = new MakePayment(); 
            //mp.payment();

            //SendMail sm = new SendMail();
            //sm.mailtouser();
            //Console.WriteLine("------------------------------");
            //Facade f = new Facade();
            //f.PlaceOrder();

            //Books books = new Onlinedelivery();
            //books.ProcessData();
            //Console.WriteLine("------------------");
            //Console.WriteLine(books.GetHashCode());
            ////Books books1 = new Physicaldelivery();
            ////books1.ProcessData();
            //books= new Physicaldelivery();
            //books.ProcessData();
            //Console.WriteLine();
            //string s = "hello";
            //Console.WriteLine(s.GetHashCode());
            //s = "sdfh";

            //Console.WriteLine(s.GetHashCode());
            //s = "hello";
            //Console.WriteLine(s.GetHashCode());
            //Console.WriteLine(s);

            NotificationService notificationService = new NotificationService();

            User user1 = new User("Alice");
            User user2 = new User("Bob");
            User user3 = new User("dsk");
            User user4 = new User("baki");

            notificationService.Subscribe(user1);
            notificationService.Subscribe(user2);
            notificationService.Subscribe(user3);
            notificationService.Subscribe(user4);

            notificationService.Unsubscribe(user2);
            notificationService.NotifyObservers("New message available!");
        }
    }
}
