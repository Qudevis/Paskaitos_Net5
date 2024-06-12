namespace Paskaita_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var populiacijos = new Dictionary<string, int>()
            {
                {"Kaunas",400000 },
                {"Vilnius",600000 },
                {"Klaipeda",200000 }
                
            };

            PrintCityPopulations(populiacijos);

            populiacijos.Add("Šiauliai",110000);

            PrintCityPopulations(populiacijos);

            if (!populiacijos.TryAdd("Panevezys", 90000))
            {
                Console.WriteLine("Deja toks jau egzistuoja ir nebuvo pridetas");
            }
            PrintCityPopulations(populiacijos);

            if (populiacijos.ContainsKey("Panevezys"))
            {
                Console.WriteLine("Sorry it already exists");
            }
            else
            {
                populiacijos.Add("Panevezys", 90000);
            }

            Console.WriteLine("My value from dictionary");
            Console.WriteLine(populiacijos["Šiauliai"]);

            populiacijos.Remove("Panevezys");

            PrintCityPopulations(populiacijos);

            Console.WriteLine(populiacijos.TryGetValue("Panevezys", out int pop));
            Console.WriteLine(pop);


            Console.WriteLine(populiacijos.TryGetValue("Šiauliai", out int pop2));
            Console.WriteLine(pop2);

            //Console.WriteLine("Enter a city you wish to enter into dictionary");
            //string city = Console.ReadLine();
            //Console.WriteLine("Enter the city's population");
            //int population = int.Parse(Console.ReadLine());

            //populiacijos.Add(city,population); // Geriau naudoti tryAdd arba patikrinti ar ContainsValue

            //PrintCityPopulations(populiacijos);

            var pazymiai = new Dictionary<string, List<int>>()
            {
                {"Jonas", new List<int>() {4,9,8,2,10} },
                {"Mantas", new List<int>() {9,1,2,7,8} },
                {"Adomas", new List<int>() {3,4,2,1,5,7} }
            };

            PrintGrades(pazymiai);

            List<int> karolioPazymiai = new List<int>() { 7, 9, 2, 1 };

            pazymiai.Add("Karolis", karolioPazymiai); // better use TryAdd
            PrintGrades(pazymiai);

            pazymiai["Karolis"].Add(11); // Better use TryAdd and TryGetValue

            PrintGrades(pazymiai);

        }

        public static void PrintCityPopulations(Dictionary<string,int> populiacijos)
        {
            foreach (var keyValuePairs in populiacijos)
            {
                Console.WriteLine($"Mieste: {keyValuePairs.Key} yra {keyValuePairs.Value} gyventoju");
            }

            Console.WriteLine("---------------------------------------------------");
        }

        public static void PrintGrades(Dictionary<string, List<int>> grades)
        {
            foreach (var keyValuePairs in grades)
            {
                Console.Write($"Student's {keyValuePairs.Key} grades are: ");
                Console.WriteLine();
                foreach (var grade in keyValuePairs.Value)
                {
                    Console.Write($"{grade} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("---------------------------------------------------");
        }
    }
}
