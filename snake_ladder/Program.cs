using System;

namespace snake_ladder
{
    class Program
    {

        public  int dieRollCount=0;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to snake ladder game");
            // Console.WriteLine(SnakeLadderGame());

            Program player1 = new Program();
              Program player2 = new Program();

            //  snake_ladder player2 = new snake_ladder();

            player1.SnakeLadderGame();
            player2.SnakeLadderGame();
            Console.WriteLine("The die roll count for player 1 is :" + player1.dieRollCount);
            Console.WriteLine("The die roll count for player 2 is :" + player2.dieRollCount);

            if (player1.dieRollCount > player2.dieRollCount)
            {
                Console.WriteLine("Player 2 won");
            }
            else
            {
                Console.WriteLine("Player 1 won");
            }

        }

        public  int PositionAfterDie(int position, int dieValue)
        {
            //dieRollCount++;

            Random random = new Random();
            int ladder = 1, snake = 2;
            int placeCheck = random.Next(1, 4);
            if (placeCheck == ladder)
            {
               

                Console.WriteLine("Ladder");
                
                    if (position + dieValue > 100)
                    {
                        position = position + 0;
                    }
                    else
                    {
                        position += dieValue;
                    }
                
             // position= PositionAfterDie(position, getDieValue());
                //Console.WriteLine("The new position after die roll is :" + position);
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

                position += 0;
            }
           // Console.WriteLine("The new position after die roll is :" + position);
            return position;
        }
        public int getDieValue()
        {
            Random random = new Random();
            int dieValue = random.Next(1, 7);
            Console.WriteLine("Die value is : " + dieValue);
            return dieValue;
        }
        public  void  SnakeLadderGame()
        {
            int position = 0;
          // int dieRollCount = 0;
            Console.WriteLine("You are at position :" + position);
            
            int dieValue = 0;
            int newPosition = 0;
            while (newPosition < 100)
            {

                dieRollCount++;
                dieValue = getDieValue();

                Console.WriteLine("Die count :" + dieRollCount);
                newPosition = PositionAfterDie(newPosition, dieValue);

                Console.WriteLine("The new position after die roll is :" + newPosition);
               
            }
           
            //return dieRollCount;
        }
        }
    }

