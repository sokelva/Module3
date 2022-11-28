using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "Елена";
            Console.WriteLine("Мое имя: {0}", MyName);
            Console.ReadKey();

            //-------------------------------------------------------

            const string Name = "\nJane";
            Console.WriteLine(MyName);
            Console.WriteLine("Привет,\n мир!");
            Console.WriteLine("Привет, мир! \n Я тебя люблю!");
            Console.WriteLine("Мне 27 лет, \t а моей сестре 25.");
            Console.WriteLine("My name is Jane.\n Мое имя Елена.");

            Console.WriteLine('\u0040');
            Console.WriteLine('\u0026');
            Console.WriteLine('\x23');
            Console.WriteLine('\x0A');


            Console.WriteLine(true);
            Console.WriteLine(false);
            Console.WriteLine(10);
            Console.WriteLine(0x0A);
            Console.WriteLine(0b11);
            Console.WriteLine(5.5);
            //Console.WriteLine(null);

            Console.ReadKey();
        }
    }
}
