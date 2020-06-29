using System;

namespace NET.FRAMEWORK_Углы_прямоугольного_треугольника
{
    class Program
    {
        static void Main(string[] args)

        {
            double a, b, A, A1, B;
            Console.Write("Введите сторону а: ");
            a = Int32.Parse(Console.ReadLine());   // конвертированние Parse

            Console.Write("Введите сторону b: ");
            b = Convert.ToInt32(Console.ReadLine()); // конвертирование Convert

            A1 = Math.Sin(a / b);
            A = A1 * 180 / Math.PI;
            B = 180 - 90 - A;

            Console.WriteLine("Угол A = " + String.Format("{0:f2}", A));
            Console.WriteLine("Угол В = " + String.Format("{0:f2}", B));


        }
    }
}