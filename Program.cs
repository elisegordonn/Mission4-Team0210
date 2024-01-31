using Mission4_Team0210;
using System.Net;
// Create an instance of the supporting class
Supporting Supporting = new Supporting();


int currentPlayer = 1;
char[] board = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
int winFlag = 0;

Console.WriteLine("Welcome to Tic-Tac-Toe!");

// Game loop
while (winFlag == 0)
{
    // Print the current board
    Supporting.Board(board);

    // Get the current player's move
    Console.WriteLine($"Player {currentPlayer}'s turn.");
    Console.Write("Enter space (1-9): ");
    int numboard = int.Parse(Console.ReadLine());
    if (numboard >= 1 && numboard <= 9 && board[numboard] != 'X' && board[numboard] != 'O')
    {
        if (currentPlayer == 1)
        {
            board[numboard] = 'X';
        }
        else
        {
            board[numboard] = 'O';
        }
        currentPlayer = (currentPlayer == 1) ? 2 : 1;
    }
    else
    {
        Console.WriteLine("Invalid move. Try again.");
    }
    Supporting.Winner(winFlag, currentPlayer, board);
}

// Game over, print the final board
Supporting.Board(board);
