using System;
using System.IO;

namespace MeresiAdatEllenorzo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string fajlUtvonal = "meresek.txt";
            double alsoHatar = 95.0;
            double felsoHatar = 105.0;

            int joMeresekSzama = 0;
            int selejtMeresekSzama = 0;
            int hianyzoAdatSzama = 0;

            Console.WriteLine("- Mérési Adatok Kiértékelése -");
            
            if (!File.Exists(fajlUtvonal))
            {
                Console.WriteLine("Hiba: A fájl nem található!");
                return; 
            }
            
            string[] sorok = File.ReadAllLines(fajlUtvonal);

            foreach (string sor in sorok)
            {
                
                string[] adatok = sor.Split(';');

                string idopont = adatok[0];
                string ertekSzoveg = adatok[1];

                try
                {
                    double mertErtek = double.Parse(ertekSzoveg);

                    if (mertErtek >= alsoHatar && mertErtek <= felsoHatar)
                    {
                        joMeresekSzama++;
                    }
                    else
                    {
                        selejtMeresekSzama++;
                        Console.WriteLine($"FIGYELMEZETÉS. Határérték túllépés {idopont}-kor: {mertErtek}");
                    }
                }
                catch (FormatException)
                {
                    hianyzoAdatSzama++;
                    Console.WriteLine($"HIBA Érvénytelen adat {idopont}-kor: '{ertekSzoveg}'");
                }
            }

            Console.WriteLine("\n-Összegzés-");
            Console.WriteLine($"Összes beolvasott sor: {sorok.Length}");
            Console.WriteLine($"Jó mérések: {joMeresekSzama}");
            Console.WriteLine($"Selejt mérések: {selejtMeresekSzama}");
            Console.WriteLine($"Érvénytelen (hibás) adatok: {hianyzoAdatSzama}");

            Console.ReadLine(); 
        }
    }
}
