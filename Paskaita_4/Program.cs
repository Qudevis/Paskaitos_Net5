using System.Globalization;

namespace Paskaita_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Iveskite savo varda");
            //string vardas = Console.ReadLine().ToUpper();

            //string pavarde = "Pavardenis";

            //switch (vardas) 
            //{
            //    case "JUSTAS": // if Vardas == Justas 
            //        Console.WriteLine("tavo grazus vardas");
            //        break;
            //    case "TOMAS": // else if Vardas == Tomas
            //        Console.WriteLine("tavo vardas irgi neblogas");
            //        break;
            //    case "ANTANAS": // else if Vardas == Antanas
            //        Console.WriteLine("Tu esi antanas");
            //        Console.WriteLine("Tavo vardas man ne tiek labai patinka");
            //        break;
            //    default: // else
            //        Console.WriteLine($"As nepazystu taves bet tavo vardas yra: {vardas} O tavo pavarde {pavarde}  "); // dolerio zenklas leidzia ivesti kintamuosius i stringo vidu su zenkliukais {kintamojo_pavadinimas}
            //        break;
            //}


            string zodis = "Labas"; // nauja stringa
            var simboliai = zodis.ToCharArray(); // eiluteje iskirsciau stringa i simboliu masyva var - iliuzija/sutrumpinimas

            //simboliai[0] = 'K';
            //simboliai[4] = 'D';

            //string pakeistasZodis = new string(simboliai);

            //Console.WriteLine(pakeistasZodis);

            simboliai[0] = (char)(simboliai[0]+5);
            simboliai[1] = (char)(simboliai[1] + 5);
            simboliai[2] = (char)(simboliai[2] + 5);
            simboliai[3] = (char)(simboliai[3] + 5);
            simboliai[4] = (char)(simboliai[4] + 5);

            Console.WriteLine(new string(simboliai));
            char.ToUpper('a');

        }
    }
}
