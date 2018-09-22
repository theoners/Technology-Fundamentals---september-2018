using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGameCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int trashedHeadset = lostGameCount / 2;
            int trashedMouse = lostGameCount / 3;
            int trashedKeyboard = 0;
            int trashedDisplay = 0;

            for (int i = 1; i <= lostGameCount; i++)
            {
                if (i%2==0 && i%3==0)
                {
                    trashedKeyboard++;
                }
            }
            if (trashedKeyboard>=2)
            {
                trashedDisplay = trashedKeyboard / 2;
            }

            double rageExpenses = trashedHeadset * headsetPrice + trashedMouse * mousePrice + 
                                 trashedKeyboard * keyboardPrice + trashedDisplay * displayPrice;

            Console.WriteLine($"Rage expenses: {rageExpenses:F2} lv.");
        }
    }
}
