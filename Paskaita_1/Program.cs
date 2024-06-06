namespace Paskaita_1
{
    internal class Program
    {



        static void Main(string[] args)
        {
            // manoDezute = Pieštukas
            // vaisiai obuolys = raudonasis_skanestas

            // int - sveikasis skaicius
            int skaicius = 11;

            // double - skaiciai su trumpmena
            double skaiciusTrump = 8.49;

            double suma = skaicius * skaiciusTrump + (5 - 4) * 3 ;

            string sakinys = "Hello how are you ";

            Console.WriteLine(sakinys);
            Console.Write("");
            Console.Write(sakinys);
            Console.Write(sakinys);
            Console.WriteLine(sakinys);
            Console.WriteLine(sakinys);

            //Console.WriteLine("/ \\");

            //string sudetinis = "Labas " + " Kaip sekasi" + "Man " + "Gerai";
            //Console.WriteLine(sudetinis);

            Console.WriteLine("labas\tkaip\tsekasi\tman\tgerai \n O, kaip tau");

            Console.WriteLine(@"Hello /\");

            string part1 = @"This is the first part
and it spans multiple lines.";

            bool arTiesa = true;

            bool arNetiesa = false;
            Console.WriteLine(arTiesa);

            char simbolis = '.';

            Console.WriteLine(simbolis);

            Console.WriteLine("simbolis");

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("I am yellow");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("I am green and everything is green");
            Console.ForegroundColor = ConsoleColor.Blue;


        }



    }
}
