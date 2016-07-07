using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] gameBoard = new string[3, 3];
            bool gameOver = false;
            string activePlayer = "O";

            while (!gameOver)
            {
                #region fill board
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        gameBoard[i, j] = " ";
                    }
                }
                #endregion

                #region show board
                Console.WriteLine(gameBoard[0, 0] + "|" + gameBoard[0, 1] + "|" + gameBoard[0, 2]);
                Console.WriteLine("-----");
                Console.WriteLine(gameBoard[1, 0] + "|" + gameBoard[1, 1] + "|" + gameBoard[1, 2]);
                Console.WriteLine("-----");
                Console.WriteLine(gameBoard[2, 0] + "|" + gameBoard[2, 1] + "|" + gameBoard[2, 2]);
                Console.WriteLine();
                #endregion

                playerSwitchFunc(ref activePlayer);
                validChoice(ref gameBoard, ref activePlayer);  //i'm unsure why this isn't working. i don't think i need to call the specific indexes here.

            }
        }
        static void playerSwitchFunc(ref string activePlayer)
        {
            if (activePlayer == "X")
            {
                activePlayer = "O";
            }
            else if (activePlayer == "O")
            {
                activePlayer = "X";
            }
            else
            {
                Console.WriteLine("You should not been seeing this message from the playerswitchfunc!");
                Console.ReadKey();
            }
        }
        static void validChoice(ref string gameBoard, ref string activePlayer)
        {
            Console.WriteLine("Please choose a location: ");
            int playerChoiceFunc;
            string stringChoice = Console.ReadLine();
            if (int.TryParse(stringChoice, out playerChoiceFunc))
            {
                if (gameBoard[playerChoiceFunc] != ' ')
                {
                    Console.WriteLine("That choice is invalid, please try again.");
                }
                else if ((playerChoiceFunc >= 0) && (playerChoiceFunc <= 8))
                {
                    
                    if (activePlayer == "X")
                    {
                        gameBoard[playerChoiceFunc] = activePlayer; //this might be trying to change a string into int rather than swapping strings?
                        Console.WriteLine("swap array space for X");
                    }
                    else if (activePlayer == "O")
                    {
                        Console.WriteLine("swap array space for O");
                    }
                    else
                    {
                        Console.WriteLine("You should not been seeing this message from the validChoice function!");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}

