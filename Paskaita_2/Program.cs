namespace Paskaita_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = "Kaunas yra Lietuvos antras pagal dydi miestas";
            char simbolis = city[7];

            //city = city.ToLower();

            //Console.WriteLine(city.Replace('a','m'));
            //city = city.Replace('a', 'm');

            //Console.WriteLine(city);

            //Console.WriteLine(city.Length);

            Console.WriteLine(city.Substring(11,5));

            string text = "CodeAcademy";

            int index = text.IndexOf("dada",5);

            Console.WriteLine(index);

            string textWithSpaces = "             Labs Kaip sekasi ";
            Console.WriteLine(textWithSpaces.Trim());





        }
    }
}
