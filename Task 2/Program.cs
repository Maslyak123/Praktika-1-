using System.Text;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число(четырехзначное):");
            string number = Console.ReadLine();

            if (number.Length == 4)
            {
                char a = number[0];
                char b = number[1];
                char c = number[2];
                char d = number[3];
                string newNumber = $"{b}{a}{c}{d}";
                Console.WriteLine("Число после перестановки:" + newNumber);
            }
            else
            {
                Console.WriteLine("Ошибка!");
            }
        }
    }
}
