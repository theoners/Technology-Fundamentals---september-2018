using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var playersSkils = new Dictionary<string, Dictionary<string, int>>();


            while (input != "Season end")
            {
                if (input.Contains("->"))
                {
                    string[] line = input.Split(" -> ");
                    string player = line[0];
                    string position = line[1];
                    int skill = int.Parse(line[2]);
                    if (!playersSkils.ContainsKey(player))
                    {
                        playersSkils.Add(player, new Dictionary<string, int>());
                    }

                    if (!playersSkils[player].ContainsKey(position))
                    {
                        playersSkils[player].Add(position, skill);
                    }

                    else
                    {
                        if (playersSkils[player][position] < skill)
                        {
                            playersSkils[player][position] = skill;
                        }
                    }
                }

                else
                {
                    string[] battle = input.Split(" vs ");
                    string firstUser = battle[0];
                    string secondUser = battle[1];

                    bool usersExist = CheckUsers(playersSkils, firstUser, secondUser);



                    if (usersExist)
                    {
                        string samePosition = "Mortal Combat:)";
                        while (samePosition!=null)
                        {
                             samePosition = CheckSamePositions(playersSkils, firstUser, secondUser);
                            if (samePosition != null)
                            {
                                Battle(playersSkils, samePosition, firstUser, secondUser);
                            }
                        }
                       
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var player in playersSkils.Where(x => x.Value.Count != 0).OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
                foreach (var skill in player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {skill.Key} <::> {skill.Value}");
                }
            }
        }

        private static void Battle(Dictionary<string, Dictionary<string, int>> playersSkils, string samePosition, string firstUser, string secondUser)
        {
            if (playersSkils[firstUser][samePosition] > playersSkils[secondUser][samePosition])
            {
                playersSkils[secondUser].Remove(samePosition);
            }
            else if (playersSkils[firstUser][samePosition] < playersSkils[secondUser][samePosition])
            {
                playersSkils[firstUser].Remove(samePosition);
            }
        }

        private static bool CheckUsers(Dictionary<string, Dictionary<string, int>> playersSkils, string firstUser, string secondUser)
        {
            if (playersSkils.ContainsKey(firstUser) && playersSkils.ContainsKey(secondUser))
            {
                return true;
            }
            return false;
        }

        private static string CheckSamePositions(Dictionary<string, Dictionary<string, int>> playersSkils, string firstUser, string secondUser)
        {
            foreach (var firstPlayerPosition in playersSkils[firstUser])
            {
                foreach (var secondPlayerPosition in playersSkils[secondUser])
                {
                    if (firstPlayerPosition.Key == secondPlayerPosition.Key)
                    {
                        return firstPlayerPosition.Key;

                    }
                }
            }

            return null;
        }
    }
}
