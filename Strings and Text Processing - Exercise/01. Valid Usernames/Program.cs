using System;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ");

            foreach (var user in input)
            {
                bool isValid = false;
                if (user.Length>3&&user.Length<16)
                {
                    for (int i = 0; i < user.Length; i++)
                    {
                        if ((user[i]>=48 && user[i]<=57)|| (user[i] >= 65 && user[i] <= 90) || (user[i] >= 97 && user[i] <= 122)|| user[i]=='-' || user[i]=='_')
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }
                }
                if (isValid)
                {
                    Console.WriteLine(user);
                }
            }
        }
    }
}
