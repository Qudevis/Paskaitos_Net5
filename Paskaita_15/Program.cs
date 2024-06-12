namespace Paskaita_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rand.Next());
            }


            string[] words = { "Labas", "kaip", "sekasi", "Man", "sekasi", "gerai" };


            for (int i = 0; i < 3; i++)
            {
                Console.Write(words[rand.Next(0,words.Length)]);
                Console.Write(" ");
            }

            Console.WriteLine();
            string text = @"The C# programming language was designed by Anders Hejlsberg from Microsoft 
            in 2000 and was later approved as an international standard by Ecma (ECMA-334) in 2002 and ISO/IEC
            (ISO/IEC 23270 and 20619[c]) in 2003. Microsoft introduced C# along with .NET Framework and Visual 
            Studio, both of which were closed-source. At the time, Microsoft had no open-source products. 
            Four years later, in 2004, a free and open-source project called Mono began, providing a cross-platform
            compiler and runtime environment for the C# programming language. A decade later, Microsoft released
            Visual Studio Code (code editor), Roslyn (compiler), and the unified .NET platform (software framework),
            all of which support C# and are free, open-source, and cross-platform. Mono also joined Microsoft but was not merged into .NET. ";

            string[] strings = text.Split(' ');


            for (int i = 0; i < 10; i++)
            {
                Console.Write(strings[rand.Next(0, strings.Length)]);
                Console.Write(" ");
            }

            Console.WriteLine();

            bool[] bools = { true, false };

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(bools[rand.Next(0, 2)]);
            }

        }
    }
}
