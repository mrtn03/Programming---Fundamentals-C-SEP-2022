using System;
using System.Collections.Generic;
using System.Text;

namespace Projects_Creation
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfTheArchitect = Console.ReadLine();
            int numberOfProcjects = int.Parse(Console.ReadLine());
            int individualProjectTime = 3;
            int timeForALLprojects = numberOfProcjects * individualProjectTime;
            Console.WriteLine($"The architect {nameOfTheArchitect} will need {timeForALLprojects} hours to complete {numberOfProcjects} project/s.");
        }
    }
}
