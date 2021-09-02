using System;

namespace Snake_Ladder_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake_Ladder_Game");
            Random r = new Random();
            int dice = r.Next(1, 6 + 1);
            int position_one = 0;
            Console.WriteLine("Position : "+position_one);
            Console.WriteLine("Dice Num is : "+dice);
        }
    }
}
