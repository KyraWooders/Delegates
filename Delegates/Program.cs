using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a new list 
            ListWithChangedEvent list = new ListWithChangedEvent();
            // create a class that litens for when the list is changed
            EventListener listener = new EventListener(list);

            list.Add("hello");
            list.Add("world");
            list.Clear();
            listener.Detatch();

            Console.ReadKey();
        }
    }
}
