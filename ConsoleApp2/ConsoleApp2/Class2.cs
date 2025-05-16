using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class2
    {
        public delegate void comethod(string st);
        public delegate object comethod2();
        public void display()
        {
            string st = "hello world";
            object o = st;

            comethod obj = testing;
           
        }

        public void testing(object st)
        {
           
        }
        public string testing1()
        {
            return "";
        }
    }
}
