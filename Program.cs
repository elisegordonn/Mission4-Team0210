

using Mission4_Team0210;
class Driver
{
    public static char currentPlayer = 'X';
    public static char[] board = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
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
            Console.WriteLine($"Player {currentPlayer}'s turn.");
            Console.Write("Enter space (1-9): ");
            int numboard = int.Parse(Console.ReadLine());
            if (numboard >= 1 && numboard <= 9 && board[numboard] == '-')
            {
                board[numboard] = currentPlayer;
                currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
            }
            else
            {
                Console.WriteLine("Invalid move. Try again.");
            }
            
        }

        // Game over, print the final board
        Supporting.Board();
        Supporting.Winner();
    }
}