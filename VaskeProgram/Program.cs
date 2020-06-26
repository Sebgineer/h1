using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace VaskeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kør = true;
            Vaskemaskine vaskemaskine = new Vaskemaskine();

            while (kør)
            {
                ShowDisplay(vaskemaskine);

                Console.WriteLine("1: Power\n2: Door\n3: Sæbe");
                Console.Write("Choice: ");
                switch (Console.ReadKey().KeyChar)
                {
                    case '1':
                        vaskemaskine.turnOnOrOff();
                        break;
                    case '2':
                        vaskemaskine.OpenCloseDoor();
                        break;
                    case '3':
                        vaskemaskine.FillSoap();
                        break;
                    case '4':
                        vaskemaskine.StartWash();
                        break;
                    default:
                        kør = false;
                        break;
                }

                Thread.Sleep(2000);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        static void ShowDisplay(Vaskemaskine vaskemaskinen)
        {
            Console.WriteLine("┌──────────────────────────────────────────────────────────────────────────────────");
            Console.WriteLine($"│Power: {vaskemaskinen.Power} | Door Close: {vaskemaskinen.Door} | Soap: {vaskemaskinen.FilledSoap} | Wash: {vaskemaskinen.Wash}");
            Console.WriteLine("└──────────────────────────────────────────────────────────────────────────────────");
        }
    }
}
