using System;

namespace _04.VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.	Брой страници в текущата книга – цяло число в интервала [1…1000]
            // 2.Страници, които прочита за 1 час – цяло число в интервала[1…1000]
            // 3.Броят на дните, за които трябва да прочете книгата – цяло число в интервала[1…1000]

            // Input
            int broiStraniciKniga = int.Parse(Console.ReadLine());
            int straniciZaChas = int.Parse(Console.ReadLine());
            int broqNaDniteZaKoitoTrqbvaDaProcheteKnigata = int.Parse(Console.ReadLine());
            // Calculations
            int timeForRead = broiStraniciKniga / straniciZaChas;
            int neobhodimiChasoveNaDen = timeForRead / broqNaDniteZaKoitoTrqbvaDaProcheteKnigata;
            // Output
            Console.WriteLine(neobhodimiChasoveNaDen);
        }
    }
}
