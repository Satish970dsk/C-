using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF
{   

    internal abstract class Books
    {
        public void ProcessData()
        {
            selectbook();
            makepayment();
            deliver();
        }
        public abstract void selectbook();
        public abstract void makepayment();
        public abstract void deliver();
    }

     class Onlinedelivery : Books
    {
        public override void selectbook()
        {
            Console.WriteLine("select book");
        }
        public override void makepayment()
        {
            Console.WriteLine("payment done");
        }
        public override void deliver()
        {
            Console.WriteLine("book delivered");
        }
    }
    internal class Physicaldelivery : Books
    {
        public override void selectbook()
        {
            Console.WriteLine("select book");
        }
        public override void makepayment()
        {
            Console.WriteLine("payment done via UPI");
        }
        public override void deliver()
        {
            Console.WriteLine("send a phycial book to actual address");
        }
    }
   
}
