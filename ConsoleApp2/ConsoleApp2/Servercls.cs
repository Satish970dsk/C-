using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Servercls
    {
        //create events
        //create delegates
        //raise an event
        //sender code

        public delegate void senderdel(string msg); // it must be void

        public event senderdel myevt;

        public void sendMessage()
        {
            // Ob_myevt will run the event in the cleint
            myevt("hi from server......");
        }
    }
}
