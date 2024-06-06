namespace Paskaita_7
{
    public class MyClass
    {
        public static int number = 5;
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter second number");
            int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Your number2 is: {number2}");


            int answer = Sum(number,7);

            Console.WriteLine(answer);

            Console.WriteLine($"Your number2 is: {number2}");

            Console.WriteLine("Press any button to exit");
            Console.ReadKey();
            double kaina = 15;
            double nuolaida = 0;
            bool result = Discount(ref kaina, out nuolaida);
            Console.WriteLine($"The Discount was applied: {result} price is: {kaina} and the discount was {nuolaida} ");

        }


        public static bool Discount(ref double price, out double discount)
        {
            discount = 0.8;
            if (hasDiscountCard())
            {
                price = price * 0.9;
                price = price * discount;
                return true;
            }
            return false;
        }

        public static bool hasDiscountCard()
        {
            return true;
        }

        public static bool MyTryParse(string unparsedText, out double answer)
        {
            int i = 0;

            while (i < unparsedText.Length)
            {
                if (!char.IsDigit(unparsedText[i]) && (unparsedText[i] != '.' || unparsedText[i] != ','))
                {
                    answer = 0;
                    return false;
                }
                i++;
            }
            answer = double.Parse(unparsedText);
            return true;
        }



        public static int Sum(int num1,  int num2 = 0) // num1 = 4 int num2 = 5
        {
            return (num1 + num2 + 1);
        }

        public static int MultiplyAndAddOne(int num1, int num2, bool addOne = false)
        {
            if (addOne)
            {
                return num1 * num2 + 1;
            }
            else
            {
                return num1 * num2;
            }
        }


        //public static void Print()
        //{
        //    Console.WriteLine("I am printing");
        //    Console.WriteLine("I am printing more");
        //    Console.WriteLine("I am printing more and evne more");
        //    Console.WriteLine("I am printing more and evne more and MOORE");
        //}

        //public static bool IsAdult(int age)
        //{
        //    return age >= 18; //True or False
        //}
        //public static void Print(string text)
        //{
        //    Console.WriteLine("Your passed text to method is: " + text);
        //}

        //public static int Sum(int number1, int number2)
        //{
        //    return (number1 + number2); 

        //}



    }
}
