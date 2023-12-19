using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl2
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IIDentifiable> citizensAndRobots = new List<IIDentifiable>();

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "End")
                {
                    break;
                }

                if (command.Length == 3)
                {
                    Citizen newCitizen = new Citizen(command[0], int.Parse(command[1]), command[2]);
                    citizensAndRobots.Add(newCitizen);
                }
                else if (command.Length == 2)
                {
                    Robot newRobot = new Robot(command[0], command[1]);
                    citizensAndRobots.Add(newRobot);
                }
            }

            string endDigits = Console.ReadLine();
            List<string> detainedIDs = new List<string>();

            foreach (var id in citizensAndRobots)
            {
                if (id.Id.EndsWith(endDigits))
                {
                    detainedIDs.Add(id.Id);
                }
            }

            foreach (var id in detainedIDs)
            {
                Console.WriteLine(id);   
            }

        }
    }
}
