using System;
using System.Collections.Generic;

namespace Raiding
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfHeroes = int.Parse(Console.ReadLine());
            List<BaseHero> heroes = new List<BaseHero>();

            for (int i = 0; i < numOfHeroes; i++)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();

                switch (heroType)
                {
                    case "Druid":
                        Druid druid = new Druid(heroName);
                        heroes.Add(druid);
                        break;
                    case "Paladin":
                        Paladin paladin = new Paladin(heroName);
                        heroes.Add(paladin);
                        break;
                    case "Warrior":
                        Warrior warrior = new Warrior(heroName);
                        heroes.Add(warrior);
                        break;
                    case "Rogue":
                        Rogue rogue = new Rogue(heroName);
                        heroes.Add(rogue);
                        break;
                    default:
                        Console.WriteLine($"Invalid hero!");
                        i--;
                        continue;
                }
            }

            int bossPower = int.Parse(Console.ReadLine());

            int totalPower = 0;

            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
                totalPower += hero.Power;
            }

            Console.WriteLine(bossPower > totalPower ? $"Defeat..." : $"Victory!");
        }
    }
}
