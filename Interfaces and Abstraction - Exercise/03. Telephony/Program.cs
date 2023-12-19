using System;
using System.Collections.Generic;

namespace Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers =
                Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] websites =
                Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


            Smartphone smartPhone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            foreach (var number in numbers)
            {
                bool isValid = true;

                if (number.Length == 10)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if (!char.IsDigit(number[i]))
                        {
                            Console.WriteLine($"Invalid number!");
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid)
                    {
                        smartPhone.Digits = number;
                        smartPhone.CallPhones();
                    }

                }
                else if (number.Length == 7)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        if (!char.IsDigit(number[i]))
                        {
                            Console.WriteLine($"Invalid number!");
                            isValid = false;
                            break;
                        }
                    }

                    if (isValid)
                    {
                        stationaryPhone.Digits = number;
                        stationaryPhone.DialPhone();
                    }
                }
            }

            foreach (var website in websites)
            {
                bool isValid = true;

                for (int i = 0; i < website.Length; i++)
                {
                    if (char.IsDigit(website[i]))
                    {
                        Console.WriteLine($"Invalid URL!");
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    smartPhone.Website = website;
                    smartPhone.BrowseTheWWW();
                }
            }

        }
    }
}
