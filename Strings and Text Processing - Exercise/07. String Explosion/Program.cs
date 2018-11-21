using System;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i]=='>')
                {
                    int explotionStreght = input[i + 1]-48;
                    if (i+explotionStreght>=input.Length-1)
                    {
                        for (int j = i; j < input.Length; j++)
                        {
                            if (input[j]!='>')
                            {
                                input = input.Remove(j, 1);
                                j--;
                            }
                        }
                        Console.WriteLine(input);
                        return;
                    }
                    for (int k = 0; k < explotionStreght; k++)
                    {
                        if (input[i+k+1]!='>')
                        {
                            input = input.Remove(i + k+1,1);
                            k--;
                            explotionStreght--;
                        }
                        else
                        {
                            explotionStreght += input[i + k + 2]-48;
                            if (i+k+explotionStreght>=input.Length-1)
                            {
                                for (int j = i+k; j < input.Length; j++)
                                {
                                    if (input[j] != '>')
                                    {
                                        input = input.Remove(j, 1);
                                        j--;
                                    }
                                }
                                Console.WriteLine(input);
                                return;
                            }
                        }
                    }
                }
            }
            Console.WriteLine(input);
        }
    }
}
