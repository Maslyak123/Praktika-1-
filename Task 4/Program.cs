namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вычислить путь, пройденный лодкой S, если ее скорость в стоячей воде v км/ч, \nскорость течения реки v1 км/ч, время движения по озеру t1 ч, а против течения реки – t2 ч.");
            Console.WriteLine("\nВведите значение для s(расстояние):");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение для v(скорость):");
            int v = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение для v1(скорость течения реки):");
            int v1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение для t1(по течению):");
            int t1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение для t2(против течения):");
            int t2 = Convert.ToInt32(Console.ReadLine());

            int s1 = v * t1;
            int s2 = t2 * (v - v1);
            s = s1 + s2;

            Console.WriteLine("Весть путь:" + s);
            Console.WriteLine("Путь по озеру:" + s1);
            Console.WriteLine("Путь по реке:" + s2);
        }
    }
}
