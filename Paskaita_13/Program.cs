using System.Text;

namespace Paskaita_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sentences = { "Hello how are you", "This is a nice day", "Are you okay", "I am doing great" };

            int[] numbers = { 4, 7, 2, 6, 9, 1, 5, 7, 8, 3, 5, 4 };


            foreach (int number in numbers) // number = numbers[0] .... number = numbers[1]... number = numbers[2]
            {
                Console.WriteLine(Squared(number));
            }
        }

        public static int Squared(int number)
        {
            return number * number;
        }
    }
}
