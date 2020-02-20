using System;

namespace ConsoleApp1_zgadywanie
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Gra za dużo za mało");

            //1. kompyter losuje
            #region losowanie
            var los = new Random();   // nazwa typu nazwa zmiennej zmienna los typu random tworze obiekt typu random
            int wylosowana = los.Next(1, 101);
#if DEBUG
            Console.WriteLine(wylosowana);
#endif
            Console.WriteLine("Wylosowałem liczbę od 1 do 100.\nOdgadnij ją!");
            #endregion

            bool odgadniete = false;
            //dopóki nie odgadniete
            while (! odgadniete )
            {
                // 2. czlowiek proponuje
                Console.Write("Podaj swoją propozycję ");
                int propozycja = int.Parse(Console.ReadLine());

                //3. komputer ocenia 
                if (propozycja < wylosowana)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Za mało");
                    Console.ResetColor();
                }
                else if (propozycja > wylosowana)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Za dużo");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Trafiono");
                    Console.ResetColor();
                    odgadniete = true;

                }
            }
            Console.WriteLine("Koniec gry");
        } 
    }
}
