using Mission4_Team0210;
class Driver
{
    public static char currentPlayer = 'X';
    public static int[] board = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    public static char GetCurrentPlayer()
    {
        return currentPlayer;
    }

    public static void SwitchPlayer()
    {
        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
    }

    public static void MakeMove(int numboard)
    {
        if (numboard >= 1 && numboard <= 9 && board[numboard] == '-')
        {
            board[numboard] = currentPlayer;
        }
        else
        {
            Console.WriteLine("Invalid move. Try again.");
        }
    }

    static void Main()
    {
        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        // Create an instance of the supporting class
        Supporting Supporting = new Supporting();

        // Game loop
        while (Supporting.Winner() != 1)
        {
            // Print the current board
            Supporting.Board();

            // Get the current player's move
            Console.WriteLine($"Player {GetCurrentPlayer()}'s turn.");
            Console.Write("Enter space (1-9): ");
            int numboard = int.Parse(Console.ReadLine());
            MakeMove(numboard);
            SwitchPlayer();
            
        }

        // Game over, print the final board
        Supporting.Board();

        // Check for a winner and display the result
        if (Supporting.Winner() = 1)
        {
            Console.WriteLine($"Player {GetCurrentPlayer()} wins!");
        }
        else
        {
            Console.WriteLine("It's a draw!");
        }
    }
}