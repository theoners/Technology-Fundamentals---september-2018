using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            string drumSetAsText = Console.ReadLine();
            List<int> drumSet = drumSetAsText
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();
            string command = Console.ReadLine();
            List<int> currentdrumSet = drumSetAsText
                                      .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                      .Select(int.Parse)
                                .ToList();
            while (command != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(command);
                

                for (int i = 0; i < currentdrumSet.Count; i++)
                {
                    
                    currentdrumSet[i] -= hitPower;
                    if (currentdrumSet[i]<=0)
                    {
                        double drumpPrice = drumSet[i] * 3;
                        if (drumpPrice<=savings)
                        {
                            currentdrumSet[i] = drumSet[i];
                            savings -= drumpPrice;
                        }
                        else
                        {
                            currentdrumSet.RemoveAt(i);
                            drumSet.RemoveAt(i);
                            i--;
                        }
                    }
                  
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(' ',currentdrumSet));
            Console.WriteLine($"Gabsy has {savings:F2}lv.");
        }
    }
}
