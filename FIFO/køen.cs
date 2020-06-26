using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{
    class køen
    {
        public static void addItem(Queue<string> queuen, string text)
        {
            queuen.Enqueue(text);
        }

        public static bool FindItem(Queue<string> queuen, string item)
        {
            return queuen.Contains(item);
        }
    }
}
