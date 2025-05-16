using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF
{
    internal class Login
    {
        public void checkuser()
        {
            Console.WriteLine("login success");
        }
    }
    internal class Product
    {
        public void addproduct()
        {
            Console.WriteLine("item added");
        }
    }
    internal class MakePayment
    {
        public void payment()
        {
            Console.WriteLine("payment done");
        }
    }
    internal class SendMail
    {
        public void mailtouser()
        {
            Console.WriteLine("mail sent");
        }
    }

    internal class Facade
    {
        Login l;
        Product p;
        MakePayment mp;
        SendMail sm;

        public Facade()
        {
            l = new Login();
            p = new Product();
            mp = new MakePayment();
            sm = new SendMail();
        }

        public void PlaceOrder()
        {
            l.checkuser();
            p.addproduct();
            mp.payment();
            sm.mailtouser();
        }
    }
}