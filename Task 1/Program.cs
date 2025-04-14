using System;


namespace Practika
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Введите значение для A(вещественное число): ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение для B(вещественное число): ");
            double B = Convert.ToDouble(Console.ReadLine());

            double x = A + B / 2;
            Console.WriteLine($"{A}/2+{B}/2={Math.Round(x,3)}");
        }
    }
}