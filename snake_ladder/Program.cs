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
            
                int dieValue = random.Next(1, 7);
                Console.WriteLine("Die value is : " + dieValue);
            

        }
    }
}
