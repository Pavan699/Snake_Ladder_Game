using System;

namespace Snake_Ladder_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake_Ladder_Game");
            Random r = new Random();
            int position_one = 0,count_one = 1;
            while (position_one != 100)
            {
                int dice = r.Next(1, 6 + 1);
                Console.WriteLine("Dice Num is : " + dice);
                position_one = position_one + dice; 
                Console.WriteLine("Position : " + position_one);
                count_one = count_one + 1;
                
                //if conditions for ladder
                if (position_one == 4)
                {
                    position_one = position_one + dice;
                    Console.WriteLine("Got Ladder :: "+position_one);
                }
                if (position_one == 13)
                {
                    position_one = position_one + dice;
                    Console.WriteLine("Got Ladder :: " + position_one);
                }
                if (position_one == 26)
                {
                    position_one = position_one + dice;
                    Console.WriteLine("Got Ladder :: " + position_one);
                }
                if (position_one == 34)
                {
                    position_one = position_one + dice;
                    Console.WriteLine("Got Ladder :: " + position_one);
                }
                if (position_one == 56)
                {
                    position_one = position_one + dice;
                    Console.WriteLine("Got Ladder :: " + position_one);
                }
                if (position_one == 76)
                {
                    position_one = position_one + dice;
                    Console.WriteLine("Got Ladder :: " + position_one);
                }
                if (position_one == 89)
                {
                    position_one = position_one + dice;
                    Console.WriteLine("Got Ladder :: " + position_one);
                }

                //if for snake
                if (position_one == 9)
                {
                    position_one = position_one - dice;
                    Console.WriteLine("Got Snake :: " + position_one);
                }
                if (position_one == 15)
                {
                    position_one = position_one - dice;
                    Console.WriteLine("Got Snake :: " + position_one);
                }
                if (position_one == 35)
                {
                    position_one = position_one - dice;
                    Console.WriteLine("Got Snake :: " + position_one);
                }
                if (position_one == 59)
                {
                    position_one = position_one - dice;
                    Console.WriteLine("Got Snake :: " + position_one);
                }
                if (position_one == 72)
                {
                    position_one = position_one - dice;
                    Console.WriteLine("Got Snake :: " + position_one);
                }
                if (position_one == 98)
                {
                    position_one = position_one - dice;
                    Console.WriteLine("Got Snake :: " + position_one);
                }

                //if for greter than 100
                if (position_one >100)
                {
                    position_one = position_one - dice;
                    Console.WriteLine("Greter than 100");
                    Console.WriteLine("Reduce dice :: "+position_one);
                }
            }
            Console.WriteLine("Repetations(Counter) of Dice for the win is :" + count_one);
        }
    }
}
