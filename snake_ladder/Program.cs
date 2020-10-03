using System;

namespace snake_ladder
{
    class Program
    {



        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Welcome to snake ladder game");
            

            Multiplayer play = new Multiplayer();
          

            play.SnakeLadderGame();
           

        }



    }
}

