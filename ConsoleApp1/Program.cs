using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    //enum DaysOfWeek : byte
    //{
    //    Monday = 1,
    //    Tusday,
    //    Wedneday,
    //    Thusday,
    //    Friday,
    //    Satuday,
    //    Sunday
    //}

    enum Semaphore
    {
        Red = 100, 
        Yellow = 200, 
        Green = 300
    }

    class Program
    {
        static void Main(string[] args)
        {
            //const string MyName = "Елена";
            //Console.WriteLine("Мое имя: {0}", MyName);
            //Console.ReadKey();

            ////-------------------------------------------------------

            //const string Name = "\nJane";
            //Console.WriteLine(MyName);
            //Console.WriteLine("Привет,\n мир!");
            //Console.WriteLine("Привет, мир! \n Я тебя люблю!");
            //Console.WriteLine("Мне 27 лет, \t а моей сестре 25.");
            //Console.WriteLine("My name is Jane.\n Мое имя Елена.");

            //Console.WriteLine('\u0040');
            //Console.WriteLine('\u0026');
            //Console.WriteLine('\x23');
            //Console.WriteLine('\x0A');


            //Console.WriteLine(true);
            //Console.WriteLine(false);
            //Console.WriteLine(10);
            //Console.WriteLine(0x0A);
            //Console.WriteLine(0b11);
            //Console.WriteLine(5.5);
            ////Console.WriteLine(null);
            ///

            //string MyName = "Елена";
            //byte age = 42;
            //bool isPet = true;
            //double size = 37.5;
            //Console.WriteLine("Мое имя:{0};\nВаш возраст:{1};\nА есть ли у вас домашний питомец:{2};\nВаш размер ноги: {3}", MyName, age, isPet, size);
            ////Console.ReadKey();

            //Console.WriteLine("IntMin {0} ", int.MinValue);
            //Console.WriteLine("IntMax {0} ", int.MaxValue);

            //Console.ReadKey();

            DaysOfWeek MyFavoriteDay;

            MyFavoriteDay = DaysOfWeek.Friday;

            Console.WriteLine(MyFavoriteDay);
            Console.ReadKey();

        }
    }
}
