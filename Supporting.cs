﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission4_Team0210
{
    //make a Supporting class for the tic tac toe board
    internal class Supporting
    {
        //make a baord method to display the tic tac toe board array from the main program
        public void Board(char[] board)
        {
            //tic tac toe board
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2} ", board[1], board[2], board[3]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2} ", board[4], board[5], board[6]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2} ", board[7], board[8], board[9]);
            Console.WriteLine("     |     |     ");
        }

        //method to determine the winner of the game
        public int Winner(int winFlag, int currentPlayer, char[] board)
        { 
         //horizontal wins:
            if (board[1] == board[2] && board[2] == board[3])
            {
                winFlag = 1;
            }
            else if (board[4] == board[5] && board[5] == board[6])
            {
                winFlag = 1;
            }
            else if (board[7] == board[8] && board[8] == board[9])
            {
                winFlag = 1;
            }
            //vertical wins
            else if (board[1] == board[4] && board[4] == board[7])
            {
                winFlag = 1;
            }
            else if (board[2] == board[5] && board[5] == board[8])
            {
                winFlag = 1;
            }
            else if (board[3] == board[6] && board[6] == board[9])
            {
                winFlag = 1;
            }

            //diagonal wins
            else if (board[1] == board[5] && board[5] == board[9])
            {
                winFlag = 1;
            }
            else if (board[3] == board[5] && board[5] == board[7])
            {
                winFlag = 1;
            }

            //if there is a draw (board is full but no winners)
            else if (board[1] != '1' && board[2] != '2' && board[3] != '3' && board[4] != '4'
                && board[5] != '5' && board[6] != '6' && board[7] != '7' && board[8] != '8' && board[9] != '9')
            {
                winFlag = -1;
            }   
           
            // if no winners, continue the game
            else
            {
                winFlag = 0;
            }

            //tell the winner that they've won, or announce draw
            if (winFlag == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Player {0} has won", (currentPlayer % 2) + 1);
                Console.WriteLine("Thanks for playing! :D");
            }
            else if (winFlag == -1)
            {
                Console.WriteLine();
                Console.WriteLine("Draw. There is no winner.");
                Console.WriteLine("Thanks for playing! :D");
            }

            return winFlag;
        }
    }
}
