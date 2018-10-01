using System;

namespace _07._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < 'a'+number; i++)
            {
                for (char k = 'a'; k < 'a' + number; k++)
                {
                    for (char j ='a'; j < 'a' + number; j++)
                    {
                        Console.WriteLine(""+i+k+j);
                    }
                }
            }
        }
    }
}
