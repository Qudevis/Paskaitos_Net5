namespace Paskaita_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kaina = 15;
            bool result = Discount(ref kaina, out double nuolaida);
            Console.WriteLine($"The Discount was applied: {result} price is: {kaina} and the discount was {nuolaida} ");
            Random rnd = new Random();
            long test = rnd.NextInt64(100, 4294967295);
            Console.WriteLine();
        }
        public static bool Discount(ref double price, out double discount)
        {
            discount = double.NaN;
            if (HasDiscountCard())
            {
                price = price * discount;
                return true;
            }
            return false;
        }

        public static bool HasDiscountCard()
        {
            return false;
        }
    }
}
