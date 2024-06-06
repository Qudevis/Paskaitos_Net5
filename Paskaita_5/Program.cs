namespace Paskaita_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Iveskite skaiciu");
            //string ivestis = Console.ReadLine();

            

            //if (string.IsNullOrEmpty(ivestis))
            //{
            //    Console.WriteLine("Ivestis buvo tuscia");
            //}


            //Console.WriteLine(int.Parse(ivestis));

            //int patikrintas = 0;

            //bool arSkaicius = int.TryParse(ivestis, out patikrintas);

            //if (arSkaicius)
            //{
            //    Console.WriteLine($"jus ivedete skaiciu {patikrintas}");
            //}
            //else
            //{
            //    Console.WriteLine($"jus ivedete ne skaiciu{patikrintas}");
            //}
            //Console.WriteLine(int.TryParse(ivestis, out patikrintas));
            

            DateTime now = DateTime.Now;

            DateTime birthDate = new DateTime(1990, 6, 15,10,15,10);

            DateTime extracted = DateTime.Parse("2024-05-23 10:10:10");

            DateTime pakeista = now.AddYears(5);

            TimeSpan subtracted = now.Subtract(birthDate);

            Console.WriteLine((subtracted.TotalDays));

            Console.WriteLine(now);
            Console.WriteLine(birthDate);

        }
    }
}
