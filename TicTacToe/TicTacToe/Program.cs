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
            string stringChoice = null;

            #region fill board
            int counter = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gameBoard[i, j] = counter.ToString();
                    counter++;
                }
            }
            #endregion

            while (gameOver == false)
            {
                

                #region show board
                Console.WriteLine(gameBoard[0, 0] + "|" + gameBoard[0, 1] + "|" + gameBoard[0, 2]);
                Console.WriteLine("-----");
                Console.WriteLine(gameBoard[1, 0] + "|" + gameBoard[1, 1] + "|" + gameBoard[1, 2]);
                Console.WriteLine("-----");
                Console.WriteLine(gameBoard[2, 0] + "|" + gameBoard[2, 1] + "|" + gameBoard[2, 2]);
                Console.WriteLine();
                #endregion

                checkWinState(ref gameOver, activePlayer, gameBoard);
                playerSwitchFunc(ref activePlayer);
                validChoice(ref gameBoard, activePlayer, ref stringChoice, ref gameOver);
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

        static void validChoice(ref string[,] gameBoard, string activePlayer, ref string stringChoice,ref bool gameOver)
        {
            Console.WriteLine("Please choose a location: ");
            int playerChoiceFunc;
            stringChoice = Console.ReadLine();
            if (int.TryParse(stringChoice, out playerChoiceFunc))
            {
                switch (stringChoice)
                {
                    case "1":
                        if (gameBoard[0, 0] == stringChoice)
                        {
                            gameBoard[0, 0] = activePlayer;
                            checkWinState(ref gameOver, activePlayer, gameBoard);

                        }
                        else
                        {
                            Console.WriteLine("This is not a valid choice");
                        }
                        break;

                    case "2":
                        if (gameBoard[0, 1] == stringChoice)
                        {
                            gameBoard[0, 1] = activePlayer;
                            checkWinState(ref gameOver, activePlayer, gameBoard);
                        }
                        else
                        {
                            Console.WriteLine("This is not a valid choice");
                        }
                        break;

                    case "3":
                        if (gameBoard[0, 2] == stringChoice)
                        {
                            gameBoard[0, 2] = activePlayer;
                            checkWinState(ref gameOver, activePlayer, gameBoard);
                        }
                        else
                        {
                            Console.WriteLine("This is not a valid choice");
                        }
                        break;
                    case "4":
                        if (gameBoard[1, 0] == stringChoice)
                        {
                            gameBoard[1, 0] = activePlayer;
                            checkWinState(ref gameOver, activePlayer, gameBoard);
                        }
                        else
                        {
                            Console.WriteLine("This is not a valid choice");
                        }
                        break;
                    case "5":
                        if (gameBoard[1, 1] == stringChoice)
                        {
                            gameBoard[1, 1] = activePlayer;
                            checkWinState(ref gameOver, activePlayer, gameBoard);
                        }
                        else
                        {
                            Console.WriteLine("This is not a valid choice");
                        }
                        break;
                    case "6":
                        if (gameBoard[1, 2] == stringChoice)
                        {
                            gameBoard[1, 2] = activePlayer;
                            checkWinState(ref gameOver, activePlayer, gameBoard);
                        }
                        else
                        {
                            Console.WriteLine("This is not a valid choice");
                        }
                        break;
                    case "7":
                        if (gameBoard[2, 0] == stringChoice)
                        {
                            gameBoard[2, 0] = activePlayer;
                            checkWinState(ref gameOver, activePlayer, gameBoard);
                        }
                        else
                        {
                            Console.WriteLine("This is not a valid choice");
                        }
                        break;
                    case "8":
                        if (gameBoard[2, 1] == stringChoice)
                        {
                            gameBoard[2, 1] = activePlayer;
                            checkWinState(ref gameOver, activePlayer, gameBoard);
                        }
                        else
                        {
                            Console.WriteLine("This is not a valid choice");
                        }
                        break;
                    case "9":
                        if (gameBoard[2, 2] == stringChoice)
                        {
                            gameBoard[2, 2] = activePlayer;
                            checkWinState(ref gameOver, activePlayer, gameBoard);
                        }
                        else
                        {
                            Console.WriteLine("This is not a valid choice");
                        }
                        break;
                    default:
                        Console.WriteLine("This isn't a valid choice!");
                        break;
                }
            }
            else
                Console.WriteLine("Please pick 1-9");
        }
        static bool checkWinState(ref bool gameOver, string activePlayer, string[,] gameBoard)
        {//horizontal win conds
            if ((gameBoard[0,0] == activePlayer) && (gameBoard[0,1] == activePlayer) && (gameBoard[0,2] == activePlayer))
            {
                Console.WriteLine("You win player {0}", activePlayer);
                return gameOver = true;
            }
            else if ((gameBoard[1, 0] == activePlayer) && (gameBoard[1, 1] == activePlayer) && (gameBoard[1, 2] == activePlayer))
            {
                Console.WriteLine("You win player {0}", activePlayer);
                return gameOver = true;
            }
            else if ((gameBoard[2, 0] == activePlayer) && (gameBoard[2, 1] == activePlayer) && (gameBoard[2, 2] == activePlayer))
            {
                Console.WriteLine("You win player {0}", activePlayer);
                return gameOver = true;
            }
            //vertical win conds
            else if ((gameBoard[0, 0] == activePlayer) && (gameBoard[1, 0] == activePlayer) && (gameBoard[2, 0] == activePlayer))
            {
                Console.WriteLine("You win player {0}", activePlayer);
                return gameOver = true;
            }
            else if ((gameBoard[0,1] == activePlayer) && (gameBoard[1, 1] == activePlayer) && (gameBoard[2, 1] == activePlayer))
            {
                Console.WriteLine("You win player {0}", activePlayer);
                return gameOver = true;
            }
            else if ((gameBoard[0, 2] == activePlayer) && (gameBoard[1, 2] == activePlayer) && (gameBoard[2, 2] == activePlayer))
            {
                Console.WriteLine("You win player {0}", activePlayer);
                return gameOver = true;
            }

            //diag win conds
            else if ((gameBoard[0, 0] == activePlayer) && (gameBoard[1, 1] == activePlayer) && (gameBoard[2, 2] == activePlayer))
            {
                Console.WriteLine("You win player {0}", activePlayer);
                return gameOver = true;
            }
            else if ((gameBoard[0, 2] == activePlayer) && (gameBoard[1, 1] == activePlayer) && (gameBoard[2, 0] == activePlayer))
            {
                Console.WriteLine("You win player {0}", activePlayer);
                return gameOver = true;
            }
            else
                return gameOver = false;  //this should be false
        }

    }
}