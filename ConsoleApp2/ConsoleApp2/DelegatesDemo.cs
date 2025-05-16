using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class DelegatesDemo
    {   
        public delegate void MyDelegate(int x);// delegate declaration
        public void Odd(int x)
        {
            Console.WriteLine(x+" is odd number");
        }
        //public void Even(int x)
        //{
        //    Console.WriteLine(x+" is even number");
        //}
        public void show(int i)
        {
            MyDelegate ob;
            if (i % 2 == 0)
            {   // method-1
                //ob = new MyDelegate(Even); // delegate instantiation
                // method-2
                //ob = Even;
                // method-3
                //ob = delegate (int x)// anonymous delegate
                //{
                //    Console.WriteLine(x + " is even number");
                //};
                // method-4
                ob = (x) => { Console.WriteLine(x + " is even number"); };// lambda expression

            }
            else
            {
                // ob = new MyDelegate(Add);
                ob = Odd;
            }
            ob.Invoke(i);// delegate invocation
        }
    }
}
