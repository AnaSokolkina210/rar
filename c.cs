using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace один
{
    class Program
    {
        static void Main(string[] args)
        {
            double S, a, P, R2, R,  Svp;
            Console.Write("введите площадь круга:  ");
            S = double.Parse(Console.ReadLine());

            R2 = S / Math.PI;
            Console.Write("радиус= ");

            R = Math.Sqrt(R2);  
            Console.WriteLine(R);

            Console.Write("сторона а= ");
            a = (2 * R)/ Math.Sqrt(3);
            Console.WriteLine(a);

            Console.Write("площадь вписанной окроружности равно стороне квадрата S=");
            Svp = ((3 * Math.Sqrt(3)) / 2) * Math.Pow(a, 2);
            Console.WriteLine(Svp);

            Console.Write("периметр Р= ");
            P = 6 * a; 
            Console.WriteLine(P);
            Console.ReadKey();
       }
    }
}
