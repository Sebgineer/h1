using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO
{
    class Program
    {
        static Queue<string> kø = new Queue<string>();
        static void Main(string[] args)
        {

            bool Exit = false;

            while (!Exit)
            {
                switch (Console.ReadKey().KeyChar)
                {
                    //Add Item
                    case '1':
                        køen.addItem(kø, Console.ReadLine());
                        break;
                    //Delete Item
                    case '2':
                        kø.Dequeue();
                        break;
                    //Show the number of items
                    case '3':
                        Console.WriteLine(kø.Count);
                        break;
                    //Show min and max items
                    case '4':
                        break;
                    //Find an item
                    case '5':
                        Console.WriteLine(køen.FindItem(kø, Console.ReadLine()));
                        break;
                    //Print all items
                    case '6':
                        foreach (var item in kø)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    //Exit
                    case '7':
                        Console.WriteLine("Closing down!");
                        Exit = true;
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
