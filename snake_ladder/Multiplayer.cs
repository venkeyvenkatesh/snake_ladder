using System;
using System.Collections.Generic;
using System.Text;

namespace snake_ladder
{
    class Multiplayer
    {
        //variables
        public int dieRollCount = 0;
        public static int position1 = 0;
        public static int position2 = 0;

        /// <summary>
        /// Positions the after die.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <param name="player">The player.</param>
        /// <returns></returns>
        public int PositionAfterDie(int position,int player)
        {


            if (position == 100)
            {
                if (player == 1)
                {
                    Console.WriteLine("Player 2 is at psotion : " + position2);
                }
                Console.WriteLine("Player " + player + " has won");


                Environment.Exit(1);
            }
            else
            {
                int ladder = 1, snake = 2;
                int placeCheck = getDieRollType();
                int dieValue = getDieValue();
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

                    Console.WriteLine("The player" + player + "  is at  :" + position);
                    position = PositionAfterDie(position, player);

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
                    Console.WriteLine("The player" + player + "  is at  :" + position);

                }
                else
                {
                    Console.WriteLine("No play");

                    position += 0;
                    Console.WriteLine("The player" + player + "  is at  :" + position);
                }


               
            }
            return position;
        }


        /// <summary>
        /// Gets the die value.
        /// </summary>
        /// <returns></returns>
        public int getDieValue()
        {
            Random random = new Random();
            int dieValue = random.Next(1, 7);
            Console.WriteLine("Die value is : " + dieValue);
            return dieValue;
        }

        /// <summary>
        /// Gets the type of the die roll.
        /// </summary>
        /// <returns></returns>
        public int getDieRollType()
        {
            Random random = new Random();
           
            int placeCheck = random.Next(1, 4);
            return placeCheck;
        }



        /// <summary>
        /// Starts the ladder game.
        /// </summary>
        public void SnakeLadderGame()
        {
            
            Console.WriteLine("Player 1 is at position :" + position1);
            Console.WriteLine("Player 2 is at position :" + position2);

           
            int player1 = 1;
            int player2 = 2;
            while (position1 < 100 && position2 < 100)
            {

                dieRollCount++;
                
                Console.WriteLine("Die roll count : " + dieRollCount);
               
                position1 = PositionAfterDie(position1,player1);
                position2 = PositionAfterDie(position2,player2);

              
                Console.WriteLine("\n");
            }

           
        }

      
    }
}

