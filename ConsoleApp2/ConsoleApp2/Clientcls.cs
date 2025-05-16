using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Clientcls
    {
        //code to receive the message
        // u have to subscribe to it +=
        Servercls ob = new Servercls();
        public Clientcls()
        {
            ob.myevt += Ob_myevt;
        }

        private void Ob_myevt(string msg)
        {   

            //receive the msg from the server
            Console.WriteLine(msg);
        }
        public void execute()
        {
            ob.sendMessage();
        }
    }
}
