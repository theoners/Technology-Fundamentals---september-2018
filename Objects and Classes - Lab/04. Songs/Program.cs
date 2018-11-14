using System;
using System.Collections.Generic;

namespace _04._Songs
{
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int songsNumber = int.Parse(Console.ReadLine());
            List<Song> songList = new List<Song>();

            for (int i = 0; i < songsNumber; i++)
            {
                string[] input = Console.ReadLine().Split("_");

                string type = input[0];
                string name = input[1];
                string time = input[2];

                Song song = new Song()
                {
                    TypeList = type,
                    Name = name,
                    Time = time
                };

                songList.Add(song);
            }

            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (var song in songList)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in songList)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }
}
