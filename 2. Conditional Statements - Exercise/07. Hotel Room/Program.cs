<<<<<<< HEAD
﻿namespace _07._Hotel_Room
=======
﻿using System.Collections.Generic;

namespace _07._Hotel_Room
>>>>>>> 9ee55e6943a4ef16fa7bbd5b6723c43fec114c55
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Console.WriteLine("Hello, World!");
=======
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioPrice = 0.0;
            double apartmentPrice = 0.0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    apartmentPrice = 65;
                    if (nights > 14)
                    {
                        studioPrice *= 0.70;
                    }
                    else if (nights > 7)
                    {
                        studioPrice *= 0.95;
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = 75.20;
                    apartmentPrice = 68.70;
                    if (nights > 14)
                    {
                        studioPrice *= 0.80;
                    }
                    break;
                case "July":
                case "August":
                    studioPrice = 76;
                    apartmentPrice = 77;
                    break;
                default: break;
            }
            if (nights > 14)
            {
                apartmentPrice *= 0.90;
            }
            Console.WriteLine($"Apartment: {apartmentPrice * nights:F2} lv.");
            Console.WriteLine($"Studio: {studioPrice * nights:F2} lv.");
>>>>>>> 9ee55e6943a4ef16fa7bbd5b6723c43fec114c55
        }
    }
}