using System;
using System.Diagnostics;
namespace GraProceduralnie
{
    class Program
    {
        const string zaduzo = "za dużo"; //const stała która w biegu programu nie ulegnie zmianie
        const string zamalo = "za mało";
        const string trafiono = "trafiono";

        static void Main(string[] args)
        {
            Console.WriteLine("Gra za dużo za mało");
            int a = WczytajLiczbę("Podaj dolny zakres losowania: ");
            int b = WczytajLiczbę("Podaj górny zakres losowania: ");
            int wylosowana = Losuj(a, b);
#if DEBUG
            Console.WriteLine(wylosowana);

            int licznik = 0;
            var stoper = new Stopwatch();
            stoper.Start();
            while (true)
            {
                licznik++; //licznik += 1;lub//licznik = licznik + 1;
                int propozycja = WczytajLiczbę("Podaj swoją propozycję lub x aby zakończyć: ");
                string wynik = Ocena(wylosowana, propozycja);
                Console.WriteLine(wynik);
                if (wynik == trafiono)
                       break;
            }
            stoper.Stop();
            Console.WriteLine($"liczba ruchów = {licznik}");
            Console.WriteLine($"czas gry = {stoper.Elapsed}");
            Console.WriteLine("Koniec gry");
#endif
        }


        /// <summary>
        /// Losuje liczbę z podanego zakresu włącznie
        /// </summary>
        /// <param name="min">dolne ograniczenie</param>
        /// <param name="max">górne ograniczenie</param>
        /// <returns></returns>
        static int Losuj(int min = 1, int max = 100) //jak nie podasz to taki przyjmie po to jest to 1 i 100
        {
            var min1 = Math.Min(min, max); //wyznacza czy min czy max które jest większe
            var max1 = Math.Max(min, max);

            var rnd = new Random();
            var los = rnd.Next(min1, max1 + 1);

            return los;
        }


        static int WczytajLiczbę(string prompt = "")
        {
            bool poprawnie = false;
            int wynik = 0;
            do
            {
                Console.Write(prompt);
                string wczytano = Console.ReadLine();
                if (wczytano == "x" || wczytano == "X")
                    Environment.Exit(0);


                try
                {
                    wynik = int.Parse(wczytano);
                    poprawnie = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Niepoprawny zapis liczby. Spróbuj jeszcze raz");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Przekroczony zakres");
                }
                catch (Exception)
                {
                    Console.WriteLine("Nieznany błąd");
                }

            }
            while (!poprawnie);

            return wynik;
        }

        static string Ocena(int wylosowana, int propozycja)
        {
            if (wylosowana < propozycja)
            {
                return zaduzo;
            }
            else if (wylosowana > propozycja)
            {
                return zamalo;
           
            }
            else
            {
                return trafiono;
            }
        }
        

       

    }

}
