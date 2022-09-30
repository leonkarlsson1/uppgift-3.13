
using System;

namespace Uppgift_3._13
{
    class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("hur gammal är du? (år) ");
            double år=double.Parse(Console.ReadLine());

            if (år >= 16 && år <= 19)
            {
                Console.WriteLine("du får komma in i tävlingen");
            }
            else
            { 
                Console.WriteLine("du får inte komma in i tävlingen");
            }

        }
    }
}




