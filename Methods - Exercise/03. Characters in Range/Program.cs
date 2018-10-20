using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            int start = Math.Min((int)firstChar,(int)secondChar);
            int end = Math.Max((int)firstChar, (int)secondChar);

            CharacterFinderInRange(start,end);
        }

        private static void CharacterFinderInRange(int start, int end)
        {
            for (int i = start+1; i < end; i++)
            {
                Console.Write((char)i+" ");
            }
        }
    }
}
