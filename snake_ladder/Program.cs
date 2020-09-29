using System;

namespace snake_ladder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to snake ladder game");

            int position = 0;
            Console.WriteLine("You are at position :" + position);

            Random random = new Random();

            while (position <= 100)
            {
                int dieValue = random.Next(1, 7);
                Console.WriteLine("Die value is : " + dieValue);
                //int noPlay = 0
                    int ladder = 1, snake = 2;

                int placeCheck = random.Next(1, 3);
                if (placeCheck == ladder)
                {
                    Console.WriteLine("Ladder");
                    position += dieValue;
                }
                else if (placeCheck == snake)
                {
                    Console.WriteLine("Snake");
                    if (position - dieValue < 0)
                    {
                        position = 0;
                    }
                    else
                    {
                        position -= dieValue;
                    }
                    
                }
                else
                {
                    Console.WriteLine("No play");
                    Console.WriteLine("No change in position");
                    position += 0;
                }

                Console.WriteLine("The new position after die roll is :" + position);
            }

        }
    }
}
