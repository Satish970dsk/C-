using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GOF
{   // shared database connections
    // any configuration which is common for all the users
    // files

    // how to create singleton
    // 1.the class should be sealed
    // 2.make the class constructor private
    // 3.create static property to generate instance
    internal sealed class Singleton
    {
        // how to create only 1 object irrespective of no of users
        // using class instance

        private Singleton() { 
            
        }
       static Singleton s = null;

        public static Singleton GetInstance
        {
            get {

                if (s == null)
                {
                    s = new Singleton();
                    return s;
                }
                else
                {
                    return s;
                }
            }
            
        }
        public void Method()
        {
            // code to intaract with database
            Console.WriteLine("singleton method");
        }

    }
}
