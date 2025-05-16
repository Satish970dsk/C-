using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class MultiCastDemo
    {   
        delegate void multicastdelg();
        delegate string mydbdelg();
        mydbdelg ob;
        delegate void gendelg<T>(T x, T y);
        public void m1()
        {
            Console.WriteLine("m1 called");
        }
        public void m2()
        {
            Console.WriteLine("m2 called");
        }
        public void display()
        {
            //multicastdelg ob =m1;
            //ob += m2; // multicast delegate
            //ob.Invoke();
            // method -2
            multicastdelg ob1, ob2, ob3;

            ob1 = m1;
            ob2 = m2;
            ob3 = ob1 + ob2; // multicast delegate
            ob3.Invoke();//syncronous invocation
           // ob3.BeginInvoke();//asyncronous invocation
        }
        public void swap<T>(T x, T y)
        {
            Console.WriteLine($"before swaping: a= {x} and b= {y}");
            T temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine($"after swaping: a= {x} and b= {y}");
         
        }
        public string mydbmethod()
        {
            Thread.Sleep(5000);
            return "mydbmethod called";
        }
        public void show()
        {
            ob= mydbmethod;
            ob.BeginInvoke(showoutput, null);
            //             callback function
            m1();

        }
        public void callgen()
        {
            gendelg<int> gn = swap<int>;
            gn.Invoke(20,50);
        }
        public void showoutput(IAsyncResult ar)// callback function
        {                                      //1.display output 2.clearing the thread
            var res = ob.EndInvoke(ar);
            Console.WriteLine(res);
        }
    }
}
