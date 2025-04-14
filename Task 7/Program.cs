namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение для а: ");
            int a = Convert.ToInt32(Console.ReadLine());

            double z1 = 1 - ((1/4) * Math.Pow(Math.Sin(2 * a), 2)) + Math.Cos(2 * a);
            double z2 = Math.Pow(Math.Cos(a), 2) + Math.Pow(Math.Cos(a), 4);

            Console.WriteLine("Результат z1: " + z1);
            Console.WriteLine("Результат z2: " + z2);
        }
    }
}
