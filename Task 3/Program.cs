namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычисление значения функции!");
            Console.WriteLine("Введите значение для x:");
            double x = Convert.ToDouble(Console.ReadLine());

            double y = Math.Pow(Math.Sin(x),3)*((x*x + 5)*(x*x + 5)) - Math.Sqrt(x/4);
            Console.WriteLine($"Результат:{Math.Round(y,3)}");
        }
    }
}
