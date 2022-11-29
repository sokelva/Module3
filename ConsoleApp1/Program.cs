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

            //DaysOfWeek MyFavoriteDay;

            //MyFavoriteDay = DaysOfWeek.Friday;

            //Console.WriteLine(MyFavoriteDay);
            //Console.ReadKey();

            //Console.WriteLine("\tПривет,\n мир!");
            //Console.ReadKey();

            //string name = "Елена";
            //byte age = 42;
            //string favcolor = "Yellow";
            //Console.WriteLine("Привет, Мир");
            //Console.WriteLine();
            //Console.WriteLine($"Меня зовут {name}");
            //Console.WriteLine($"Мой возраст {age}\nМое имя {name}");
            //Console.WriteLine("{0}\n {1}\n {2}", name, age, favcolor);

            //Console.WriteLine($"\n{age}\n{name}\n{favcolor}");

            //Console.ReadLine();


            //string MyName = "Computer";
            //Console.WriteLine("Привет, человек");
            //Console.WriteLine("Меня зовут {0}", MyName);
            //Console.Write("А как тебя зовут? ");
            //string YourName = Console.ReadLine();
            //Console.Write("Рад встрече, {0} ", YourName);

            //Console.ReadKey();

            //string str = Console.ReadLine();
            //Console.Write("Прочитал: {0} ", str);
            //Console.ReadKey();

            //double result = 5.0 / 2.0;
            //Console.WriteLine("5 / 2 = {0}", result);

            //double result = 5.0 % 2.0;
            //Console.WriteLine("5 % 2 = {0}", result);

            //double result = 10.0 / 4.0;
            //Console.WriteLine("10.0 / 4.0 = {0}", result);

            //int counter = 10;
            //Console.WriteLine("Value: {0} Increment: {1}", counter, ++counter);

            //-- 3/6/3
            //Запишите 5 делить на 2 умножить на 3 в переменную result типа double.

            //double result = 5.0 / 2.0 * 3.0; //2,5*5.0
            //Console.WriteLine("Value: {0}", result);

            //double result = 5 % 6;
            //int b = 7;
            //b -= - 6;
            //Console.WriteLine("Value: {0}", b);
            //Console.ReadKey();

            int olddata = 6;
            byte data = (byte)olddata;
            Console.WriteLine("Value: {0}", data);
            Console.ReadKey();

        }
    }
}
