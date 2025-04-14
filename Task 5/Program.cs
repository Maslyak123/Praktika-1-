namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Расстояние до дачи(и обратно): ");
            double s = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Расход авто(на 100 км): ");
            double v = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Цена 1 литра бензина: ");
            double price = Convert.ToDouble(Console.ReadLine());

            double result = (2*s * v/100) * price;

            Console.WriteLine($"Цена поездки: {result} руб.");
        }
    }
}
