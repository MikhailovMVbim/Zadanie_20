using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
-       метод получает входным параметром переменную типа double;
-       метод возвращает значение типа double, которое является результатом вычисления.

Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
-       длину окружности по формуле D = 2 * π* R;
-       площадь круга по формуле S = π* R²;
-       объем шара. Формула V = 4/3 * π * R³.
Методы должны быть объявлены как статические.
 */

namespace Zadanie_20
{
    class Program
    {
        delegate double MyDelegate(double x);
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 20. Делегаты");
            Console.WriteLine("------------------------------------");
            Console.Write("Введите значение радиуса: ");
            double r = Convert.ToDouble(Console.ReadLine());
            MyDelegate myDelegate = Lenght;
            myDelegate += Square;
            myDelegate += Volume;
            if (myDelegate!=null)
            {
                myDelegate(r);
            }
            
            Console.ReadKey();
        }

        static double Lenght(double r)
        {
            double l = 2 * Math.PI * r;
            Console.WriteLine("Длина окружности: \t{0:f4}",l);
            return l;
        }

        static double Square(double r)
        {
            double s = Math.PI * r * r;
            Console.WriteLine("Площадь круга: \t\t{0:f4}",s);
            return s;
        }

        static double Volume(double r)
        {
            double v = Math.PI * r * r * r * 4 / 3;
            Console.WriteLine("Объем шара: \t\t{0:f4}",v);
            return v;
        }

    }
}
