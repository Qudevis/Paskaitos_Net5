namespace Paskaita_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 1, 4, 7, 9, 3, -2, 4, -8, 5, 4, 5, 4, 7, 5, 401, -6 };
            //int[] numbers2 = new int[numbers.Length];

            //Print(numbers,5);
            //var returnedArray = ArraySquared(numbers);
            //Console.WriteLine("Po kelimo kvadratu");
            //Print(numbers);

            //Console.WriteLine("Grazintas mąsyvas");
            //Print(returnedArray);

            //string word = "Hello my name is Justas and I am a Software Engineer";
            //Console.WriteLine(word[0]);
            //PrintEveryLetter(word.ToCharArray());

            string[] arrayItem = { "Labas", "vakaras", "mano", "mieli", "biciuliai", "ir", "draugai" };
            RemoveElement(arrayItem, 2);
        }

        public static void PrintEveryLetter(char[] letters)
        {
            for (int i = 0; i < letters.Length; i++)
            {
                Console.WriteLine(letters[i] + "|");
            }
        }

        public static void Print(int[] arrayToBePrinted)
        {

            for (int i = 0; i < arrayToBePrinted.Length; i++)
            {
                Console.WriteLine($"{i} - tasis masyvo elementas yra: {arrayToBePrinted[i]}");
            }
        }

        public static void RemoveElement(string[] array, int indexToRemove)
        {
            string[] newArray = new string[array.Length - 1];
            int newIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i != indexToRemove)
                {
                    newArray[newIndex] = array[i];
                    newIndex++;
                }
            }
            Console.WriteLine("Masyvas su istrintu elementu:");
            foreach (string item in newArray)
            {
                Console.WriteLine(item);
            }
        }

        public static int[] ArraySquared(int[] arrayToBePrinted)
        {
            int[] newArray = new int[arrayToBePrinted.Length];

            for (int i = 0; i < arrayToBePrinted.Length; i++)
            {
                newArray[i] = arrayToBePrinted[i] * arrayToBePrinted[i];
            }

            return newArray;
        }

    }
}
