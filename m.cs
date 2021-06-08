using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace два
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, y1, y2;
            Console.WriteLine("Введите X для точки A: ");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите Y для точки A: ");
            y1 = Convert.ToInt32(Console.ReadLine());

              if (x1>=0)
                if(y1>=0)
                 Console.WriteLine(" 1 квадрат точка А");
            if (x1 >= 0)
                if (y1 <= 0)
                    Console.WriteLine(" 2 квадрат точка А");
            if (x1 <= 0)
                if (y1 <= 0)
                    Console.WriteLine(" 3 квадрат точка А");
            if (x1 <= 0)
                if (y1 > 0)
                    Console.WriteLine(" 4 квадрат точка А");

            Console.WriteLine("Введите X для точки B: ");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите Y для точки B: ");
            y2 = Convert.ToInt32(Console.ReadLine());

                       if (x2 >= 0)
                if (y2 >= 0)
                    Console.WriteLine(" 1 квадрат точка В");
            if (x2 >= 0)
                if (y2 <= 0)
                    Console.WriteLine(" 2 квадрат точка В");
            if (x2 <= 0)
                if (y2 <= 0)
                    Console.WriteLine(" 3 квадрат точка В");
            if (x2 <= 0)
                if (y2 > 0)
                    Console.WriteLine(" 4 квадрат точка В");


            int first = Math.Abs(x1) + Math.Abs(y1);
            int second = Math.Abs(x2) + Math.Abs(y2);
            if (first == second)
                Console.WriteLine(" Равноудалены.");
            else
                if (first > second)
                Console.WriteLine("Первая точка дальше.");
            else
                Console.WriteLine("Вторая точка дальше.");
            Console.ReadKey();
        }
    }
}
