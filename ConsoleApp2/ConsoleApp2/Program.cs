using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    internal class Program
    {
        //public static bool mylogic(int x)
        // {
        //     return x > 50;
        // }
        static void Main(string[] args)
        {

            #region // events demo
            Clientcls cl = new Clientcls();
            cl.execute();

            #endregion

            #region // multicast delegate demo

            //MultiCastDemo ml = new MultiCastDemo();
            //ml.display();
            //ml.show();
            //ml.callgen();
            //BuitinDelgate bt = new BuitinDelgate();
            //bt.display();
            //Console.ReadLine();

            #endregion

            #region // delegates demo
            //DelegatesDemo dl = new DelegatesDemo();
            //dl.show(21);
            // myrealdelg d = (x) => { return x > 50; }; // lambda expression
            //DelegatesRealtime dr = new DelegatesRealtime();
            //int[] k = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            //dr.FilterMethod(k, (x) => x > 50);
            //Console.WriteLine("====================================");
            //dr.FilterMethod(k, (x) => x > 50 && x < 80);
            //Console.WriteLine("====================================");
            //dr.FilterMethod(k, (x) => x > 50 && x < 80 || x > 120);

            //List<int> l = new List<int>();


            #endregion
        }
    }
}
