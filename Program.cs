// Group 4-8 | Kolton Gustin, Kaitlyn Fitzgerald, Becca Harrison, Jooyoung Jeon | Mission 4
// Class Support
// pubic PrintBoard(board) - prints the board to the console
// public string ValidWinner(board) - checks if there is a winner

string[] board = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
bool gameOver = false;

Console.WriteLine("Welcome to Tic Tac Toe!");
Console.WriteLine("Player 1 is X and Player 2 is O");
Console.WriteLine("Player 1 goes first");

while (!gameOver)
{
    s.PrintBoard(board);
    Console.WriteLine("Player 1, to place your X, choose a number between 1 and 9: ");
    string choice = Console.ReadLine();

    if (board.Contains(choice) && int.TryParse(choice, out _))
    {
        board[Array.IndexOf(board, choice)] = "X";
    }
    else
    {
        Console.WriteLine("Invalid choice, please try again.");
    }


    if (s.ValidWinner(board) == "X")
    {
        Console.WriteLine("Player 1 wins! Good job!");
        gameOver = true;
    }
    if (s.ValidWinner(board) == "Tie")
    {
        Console.WriteLine("It's a tie!");
        gameOver = true;
    }


    Console.WriteLine("Player 2, to place your O, choose a number between 1 and 9: ");
    choice = Console.ReadLine();

    if (board.Contains(choice) && int.TryParse(choice, out _))
    {
        board[Array.IndexOf(board, choice)] = "O";
    }
    else
    {
        Console.WriteLine("Invalid choice, please try again.");
    }

    if (s.ValidWinner(board) == "O")
    {
        Console.WriteLine("Player 2 wins! Good job!");
        gameOver = true;
    }
}
Console.WriteLine("Thanks for playing!");
