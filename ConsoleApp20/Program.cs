using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    // Создадим делегат
    delegate double DoubleOperation(double i);

    class Program
    {
        // Организуем ряд методов
        static double Dl(double r)
        {
            return 2*Math.PI*r;
        }

        static double S(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }

        static double V(double r)
        {
            return (4/3)*Math.PI * Math.Pow(r, 3);
        }

        static void Main()
        {
            // Сконструируем делегат
            DoubleOperation r1 = new DoubleOperation(Dl);

            double result = r1(5);
            Console.WriteLine("Длина: " + result);

            // Изменим ссылку на метод
            r1 = new DoubleOperation(S);
            result = r1(5);
            Console.WriteLine("Площадь: " + result);
            r1 = new DoubleOperation(V);
            result = r1(5);
            Console.WriteLine("Объем: " + result);

            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
