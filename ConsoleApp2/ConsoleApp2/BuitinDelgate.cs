using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class BuitinDelgate
    {   
        public void add()
        {
            Console.WriteLine("add called");
        }
        public void sub(int x, int y)
        {
            Console.WriteLine("sub is "+(x-y));
        }
        public string multi(int x, int y)
        {
            return "multi is " + x * y;
        }
        public void display()
        {
            Action a = add;
            a.Invoke();
            Console.WriteLine("=============================");
            Action<int,int> b = sub;   
            b.Invoke(20,10);
            Console.WriteLine("=============================");
            Func<int, int,string> f = multi;
            Console.WriteLine(f.Invoke(20, 10));
            Console.WriteLine("=============================");
            Func<int, double> fc =factorial;
            Console.WriteLine(fc.Invoke(0));
        }
        public double factorial(int x)
        {
            if(x==0 || x==1) return 1;
            return x*factorial(x-1);
        }


    }
}
