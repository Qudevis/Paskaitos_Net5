namespace Paskaita_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //bool isNumber = false;
            //while (isNumber != true) // šitas tikrinamas tol, kol netiesa
            //{
            //    Console.WriteLine("Iveskite skaiciu");
            //    string ivestis = Console.ReadLine();
            //    isNumber = int.TryParse(ivestis, out int correctNumber);

            //}

            //if (i < 10) // patikrinamas tik karta
            //{
            //    Console.WriteLine(i);
            //}

            //int i = 0;
            //while (i < 5)
            //{
            //    Console.WriteLine(i);
            //    i++; // i = i + 1
            //}

            //Console.WriteLine("Pabaiga");

            //int questionAmount = 6;

            //while (questionAmount > 0)
            //{
            //    Console.WriteLine($"Klausiu klausimo {questionAmount}");
            //    questionAmount--; // questionAmount = questionAmount - 1
            //}

            //int i = 0;
            //int j = 0;
            //while (i < 100)
            //{
            //    Console.WriteLine("Outer loop : " + i);
            //    while (j < 10000)
            //    {
            //        Console.WriteLine("Inner loop: " + j);
            //        j++;
            //    }
            //    j = 0;
            //    i++;
            //}


            //int i = 0;
            //do
            //{
            //    Console.WriteLine("Sukuosi");
            //    i++;
            ////} while (5 > i);

            //string text = "Hello"; // H - 0 e - 1 l -2 l -3 o - 4
            //string result = "";
            //int i = text.Length - 1; //text length - 5
            //while (i > -1)
            //{
            //    result = result + text[i];
            //    i--;
            //}

            //Console.WriteLine(result);


            //int i = 0;

            //while (i < 5)
            //{
            //    i++;// i= i+1
            //    Console.WriteLine(i);
            //}

            //while (i > 0)
            //{
            //    Console.WriteLine(i);
            //    i--;// i= i+1
            //}

            //int i = 0;

            //while (i < 10)
            //{
            //    i = i + 2;// i += 2
            //    Console.WriteLine(i);
            //    //if (i % 2 == 0)
            //    //{
            //    //    Console.WriteLine(i); //alternatyva
            //    //}
            //}

            //int i = 1;
            //int sum = 1;
            //while (i > 0)
            //{
            //    Console.WriteLine("Iveskite skaiciu kurio faktorialo norite");
            //    if (int.TryParse(Console.ReadLine(), out i))
            //    {
            //        sum = 1;
            //        while (i > 1)
            //        {
            //            sum = sum * i;
            //            i--;
            //        }

            //        Console.WriteLine($"Jusu atsakymas yra: {sum}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("ivedete neskaiciu");
            //        i = 1;
            //    }

            //}


            //Console.WriteLine("Enter a positive integer: ");
            //string userInput = Console.ReadLine();
            //string result = string.Empty;

            //if (int.TryParse(userInput, out int number))
            //{
            //    if (number < 1)
            //    {
            //        Console.WriteLine("You had to enter positive number....");
            //    }
            //    else
            //    {

            //        int i = 0;

            //        while (i < userInput.Length)
            //        {
            //            result = result + $"{userInput[i]},";

            //            i++;
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input.");
            //}

            //Console.WriteLine("result, ".Trim([',',' ']));



            
            //Console.WriteLine("Hello program is finishing...");

            do
            {
                Console.WriteLine("Condition is true...");   
            } while (4 > 5);


        }
    }
}
