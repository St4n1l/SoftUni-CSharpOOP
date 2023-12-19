using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<AbstractClassBirthdays> citizensAndPets = new List<AbstractClassBirthdays>();

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "End")
                {
                    break;
                }

                if (command[0] == "Citizen")
                {
                    Citizen newCitizen = new Citizen(command[1], int.Parse(command[2]), command[3], command[4] );
                    citizensAndPets.Add(newCitizen);
                }
                else if (command[0] == "Pet")
                {
                    Pet newPet = new Pet(command[1], command[2]);
                    citizensAndPets.Add(newPet);
                }
            }

            string endDigits = Console.ReadLine();
            List<string> validBirthdates = new List<string>();

            foreach (var item in citizensAndPets)
            {
                if (item.Birthdays.EndsWith(endDigits))
                {
                    validBirthdates.Add(item.Birthdays);
                }
            }

            foreach (var birthdate in validBirthdates)
            {
                Console.WriteLine(birthdate);   
            }

        }
    }
}
