using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public delegate bool myrealdelg(int x);// delegate declaration
    internal class DelegatesRealtime
    {
        public void FilterMethod(int[] data,myrealdelg d)
        {
            foreach(int i in data)
            {
                if (d.Invoke(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
