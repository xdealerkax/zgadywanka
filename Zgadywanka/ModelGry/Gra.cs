using System;
using System.Collections.Generic; // biblioteka która nam dostarcza kolekcji które potrzebujemy

namespace ModelGry
{
    public class Gra
    {
        //dane
        private readonly int wylosowana = 0; //readonly przed nazwą ndanych to te dane raz mogą być przepisane
        public StanGry Stan { get; private set; } // property kazy moe odczytać stan gro ale nikt nie może tego zmienić

        public List<Ruch> HistoriaGry { get; }

        // metody
       public Gra(int a = 1, int b = 100) //konstruktor utworzyć i zainicjowac wszystkie zmienne
       {
            Random rnd = new Random();
            wylosowana = rnd.Next(a, b+1);
            Stan = StanGry.Trwa;
            HistoriaGry = new List<Ruch>();  // ruch parametr typu
       }

        public int Wylosowana // properties get
        {
           get
           {
                if (Stan == StanGry.Zakonczona)
                    return wylosowana;
                else
                    throw new NotSupportedException("W trakcie gry nie dostaniesz tej informacji ");
           }
        }

        public Odp Odpowiedz(int propozycja) // jest typu odp
        {

            if (propozycja < wylosowana)
            {
                HistoriaGry.Add(new Ruch(propozycja, Odp.ZaMalo));
                return Odp.ZaMalo;
            }
            else if (propozycja > wylosowana)
            {
                HistoriaGry.Add(new Ruch(propozycja, Odp.ZaDuzo));
                return Odp.ZaDuzo;
            }

            else
            {
                HistoriaGry.Add(new Ruch(propozycja, Odp.Trafiono));
                Stan = StanGry.Zakonczona;
                return Odp.Trafiono;
            }

               
        }

        public void Poddaj()
        {
            Stan = StanGry.Zakonczona;
        }




    }

    public enum StanGry // enum to typ w którym definiujemy zestaw stałych
    { 
        Rozpoczeta,
        Trwa,
        Zapauzowana,
        Zakonczona
    }

    public enum Odp  // przykrywka dla inta, enum własny typ danych , wymienienie elementow ktore bierzemy pod uwage
    { 
        ZaMalo = -1,
        Trafiono = 0,
        ZaDuzo = 1
    }
}
