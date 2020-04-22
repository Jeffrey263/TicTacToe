using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeEngine;

namespace TicTacToeConsole
{

    class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine();
            Boolean running = true;
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine(engine.Board());

            while (running)
            {
                Console.WriteLine(engine.status + ": ");
                String selection = Console.ReadLine();


                if (engine.ChooseCell(selection))
                {
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    Console.WriteLine(engine.Board());
                }
                else
                {
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    Console.WriteLine("You can't choose that cell");
                    Console.WriteLine(engine.Board());
                }

                string checkWon = engine.CheckForWin();

                if (checkWon.Equals("PLAYER O WINS") || checkWon.Equals("PLAYER X WINS"))
                {
                    Console.WriteLine("\n\n\n\n " + checkWon + "\n\n\n");
                    Console.WriteLine("play again?: yes/no");
                    string playAgain = Console.ReadLine();

                    switch (playAgain)
                    {
                        case "yes":
                            engine.Restart();
                            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                            Console.WriteLine(engine.Board());
                            break;
                        case "no":
                            running = false;
                            break;
                    }
                    
                }

            }
            

        }


        
    }
}
