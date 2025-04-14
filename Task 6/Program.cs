using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи  3 значное число: ");
            string chislo = Convert.ToString(Console.ReadLine());

                char a = chislo[0];
                char b = chislo[1];
                char c = chislo[2];
            int digitA = int.Parse(a.ToString());
            int digitC = int.Parse(c.ToString());

            int sum = digitC + digitA;

            Console.WriteLine("Результат:" + sum);
        }
    }
}
