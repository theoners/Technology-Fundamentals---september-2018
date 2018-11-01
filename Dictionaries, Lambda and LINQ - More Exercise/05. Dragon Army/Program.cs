using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Dragon_Army
{
    class Program
    {
        static void Main(string[] args)
        {
            int dragonCount = int.Parse(Console.ReadLine());
            var dragonStats = new Dictionary<string, SortedDictionary<string, string>>();
            var dragonDamages = new Dictionary<string, int>();
            var dragonArmors = new Dictionary<string, int>();
            var dragonHealts = new Dictionary<string, int>();

            for (int i = 0; i < dragonCount; i++)
            {
                string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string dragonType = input[0];
                string dragonName = input[1];
                string dragonDamage = input[2];
                string DragonId = dragonType + " " + dragonName;
                if (input[2] == "null")
                {
                    dragonDamage = "45";
                }
                string dragonHealth = input[3];
                if (input[3] == "null")
                {
                    dragonHealth = "250";
                }
                string dragonArmor = input[4];
                if (input[4] == "null")
                {
                    dragonArmor = "10";
                }

                string dragonStat = dragonDamage + " " + dragonHealth + " " + dragonArmor;
                if (!dragonStats.ContainsKey(dragonType))
                {
                    dragonStats.Add(dragonType, new SortedDictionary<string, string>());
                }
                if (!dragonStats[dragonType].ContainsKey(dragonName))
                {
                    dragonStats[dragonType].Add(dragonName, dragonStat);

                }
                else
                {
                    dragonStats[dragonType][dragonName] = dragonStat;
                }
            }

            foreach (var dragon in dragonStats)
            {
                foreach (var stat in dragon.Value)
                {
                    if (!dragonArmors.ContainsKey(dragon.Key))
                    {
                        dragonArmors.Add(dragon.Key, 0);
                    }

                    dragonArmors[dragon.Key] += int.Parse(stat.Value.Split(' ')[2]);

                    if (!dragonDamages.ContainsKey(dragon.Key))
                    {
                        dragonDamages.Add(dragon.Key, 0);
                    }

                    dragonDamages[dragon.Key] += int.Parse(stat.Value.Split(' ')[0]);

                    if (!dragonHealts.ContainsKey(dragon.Key))
                    {
                        dragonHealts.Add(dragon.Key, 0);
                    }

                    dragonHealts[dragon.Key] += int.Parse(stat.Value.Split(' ')[1]);
                }
            }

            foreach (var dragon in dragonStats)
            {
                double damage = dragonDamages[dragon.Key];
                double armor = dragonArmors[dragon.Key];
                double health = dragonHealts[dragon.Key];
                Console.WriteLine($"{dragon.Key}::({(damage / dragon.Value.Values.Count()):F2}" +
                                  $"/{(health / dragon.Value.Values.Count()):F2}" +
                                  $"/{(armor / dragon.Value.Values.Count()):F2})");

                foreach (var stat in dragon.Value)
                {
                    Console.WriteLine($"-{stat.Key} -> damage: {int.Parse(stat.Value.Split(' ')[0])}, " +
                                      $"health: {int.Parse(stat.Value.Split(' ')[1])}, " +
                                      $"armor: {int.Parse(stat.Value.Split(' ')[2])}");
                }
            }
        }
    }
}
