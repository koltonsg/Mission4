// Group 4-8 | Kolton Gustin, Kaitlyn Fitzgerald, Becca Harrison, Jooyoung Jeon | Mission 4
// Class Support
// pubic PrintBoard(board) - prints the board to the console
// public string ValidWinner(board) - checks if there is a winner
using System.ComponentModel.Design;
using Mission4;

Support s = new Support();
string[] board = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
bool gameOver = false;
bool valid = true;
string choice = "";

Console.WriteLine("Welcome to Tic Tac Toe!");
Console.WriteLine("Player 1 is X and Player 2 is O");
Console.WriteLine("Player 1 goes first");

while (!gameOver)
{
    while (valid)
    {
        // printing the board for them to see and asking player 1 to make their choice
        s.PrintBoard(board);
        Console.WriteLine("Player 1, to place your X, choose a number between 1 and 9: ");
        choice = Console.ReadLine();

    // adding player one's choice to the board array
        if (board.Contains(choice) && int.TryParse(choice, out _))
        {
            board[Array.IndexOf(board, choice)] = "X";
            valid = false;
        }
        else
        {
            Console.WriteLine("Invalid choice, please try again.");
        }
    }
    // seeing if player 1 has won
    if (s.ValidWinner(board) == "X")
    {
        Console.WriteLine("Player 1 wins! Good job!");
        gameOver = true;
        break;
    }

    // checking for a tie
    if (s.ValidWinner(board) == "Tie")
    {
        Console.WriteLine("It's a tie!");
        gameOver = true;
    }

    while (!valid)
    {
        // letting player 2 make their choice
        s.PrintBoard(board);
        Console.WriteLine("Player 2, to place your O, choose a number between 1 and 9: ");
        choice = Console.ReadLine();

    // replacing player two's choice 
    
        if (board.Contains(choice) && int.TryParse(choice, out _))
        {
            board[Array.IndexOf(board, choice)] = "O";
            valid = true;
        }
        else
        {
            Console.WriteLine("Invalid choice, please try again.");
        }
    }
    // seeing if player 2 wins
    if (s.ValidWinner(board) == "O")
    {
        Console.WriteLine("Player 2 wins! Good job!");
        gameOver = true;
    }
}
Console.WriteLine("Thanks for playing!");
