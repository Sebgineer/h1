using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaskeProgram
{
    class Vaskemaskine
    {
        private bool power, filledSoap, wash;
        private bool door = true;

        public bool Power { get { return this.power; } }
        public bool Door { get { return this.door; } }
        public bool FilledSoap { get { return this.filledSoap; } }
        public bool Wash { get { return this.wash; } }




        public void turnOnOrOff()
        {
            if (this.power)
            {
                this.power = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nVaskemaskinen bliver slukket");
            }
            else if (!this.power)
            {
                this.power = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nVaskemaskinen bliver tændt");
            }
        }

        public void OpenCloseDoor()
        {
            if (this.door)
            {
                if (this.wash)
                {
                    this.wash = false;
                    Console.WriteLine("\nVaskemaskinen Stoppet fordi du åbnede den");
                }
                this.door = false;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nDøren bliver åbenet");
            }
            else if (!this.door)
            {
                this.door = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nDøren bliver Lukket");
            }
        }

        public void FillSoap()
        {
            if (!this.filledSoap)
            {
                this.filledSoap = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nSæben bliver heldt i");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nDer er allerede sæbe i");
            }
        }

        public void StartWash()
        {
            if (this.power && this.door)
            {
                if (this.wash)
                {
                    this.wash = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nVaskemaskinen bliver stoppet");
                }
                else if (!this.wash)
                {
                    this.wash = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nVaskemaskinen bliver sat i gang");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nVaskemaskinen er ikke tændt, eller døren står åben");
            }
        }
    }
}
