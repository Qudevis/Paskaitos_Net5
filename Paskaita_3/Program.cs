namespace Paskaita_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int amzius = 22;
            int limitas = 20;

            if (amzius >= 65)
            {
                Console.WriteLine("Gaunate pensija");
            }
            else if (amzius >= 21 && amzius < 65)
            {
                Console.WriteLine("Galima nusipirkti alkoholio");
            }
            else if (amzius > 18 && amzius < 21)
            {
                Console.WriteLine("Galite nusipirkti energetini");
            }
            else
            {
                Console.WriteLine("Neaktualu");
            }


            if (amzius > 18)
            {
                Console.WriteLine("Isorinis");
                if ("vardas" == "Jonas")
                {
                    Console.WriteLine("Vidinis");
                }
            }
            else
            {

            }
            if (amzius > 20)
            {
                Console.WriteLine("Gali nusipirkti alkoholio");
            }
            else
            {

            }


            Console.WriteLine("Už ribų");

            //int manoAmzius = int.Parse(Console.ReadLine());

            //if(manoAmzius > 15)

            //Console.WriteLine("Jusu amzius yra: " + (manoAmzius+"" + manoAmzius));
            bool arTiesa = 5 > 4;

            // bool - tik true arba false
            // 4 > 5 - false        !(4>5) - True

            if (4 > 5 && 5 > 4 && 2 > 1 && "labas" == "labas")
            {
                Console.WriteLine("Abi sąlygos teisingos");
            }
            else
            {
                Console.WriteLine("Kažkuri salyga neteisinga");
            }

            if (5 > 4 || 3 > 6 || 5 > 4 || 8 > 20)
            {
                Console.WriteLine("Kazkuris teisingas");
            }
            //      false         ||      true
            if ( (5 > 4 && 4 > 3) || (2 > 1) )
            {
                Console.WriteLine("paskutinis veikia");
            }

        }
    }
}
