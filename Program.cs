using System;
using System.Collections.Generic;
using System.Text;

namespace _09.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input 
            int duljinaCM = int.Parse(Console.ReadLine());
            int shirochinaCM = int.Parse(Console.ReadLine());
            int visochinaCM = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            // Calculations
            double obemNaAkvarium = duljinaCM * shirochinaCM * visochinaCM;
            double obemLitres = obemNaAkvarium / 1000;
            double nujniLitri = obemLitres * (1 - percent / 100);


            // Output 
            Console.WriteLine(nujniLitri);
        }
    }
}
