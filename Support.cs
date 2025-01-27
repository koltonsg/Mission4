namespace Mission4
{
    internal class Support
    {
        public void PrintBoard(string[] arr)
        {
            int index = 0;
            
            Console.WriteLine("Tic-Tac-Toe Board:");
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    index = i * 3 + j;
                    
                    Console.Write(arr[index]); 
                    if (j < 2) Console.Write(" | "); // Add a separator between columns
                } 
                Console.WriteLine();
                
                if (i < 2) Console.WriteLine("---------"); // Add a separator between rows
            }
        }

        public string ValidWinner(string[] arr)
        {
            // Check rows
            for (int i = 0; i < 3; i++)
            {
                if (arr[i * 3] == arr[i * 3 + 1] && arr[i * 3] == arr[i * 3 + 2] && arr[i * 3] != " ")
                {
                    return arr[i * 3]; // Return the winner symbol (X or O)
                }
            }

            // Check columns
            for (int i = 0; i < 3; i++)
            {
                if (arr[i] == arr[i + 3] && arr[i + 3] == arr[i + 6] && arr[i] != " ")
                {
                    return arr[i]; // Return the winner symbol (X or O)
                }
            }

            // Check diagonals
            if (arr[0] == arr[4] && arr[4] == arr[8] && arr[0] != " ")
            {
                return arr[0]; // Return the winner symbol (X or O)
            }
            else if (arr[2] == arr[4] && arr[4] == arr[6] && arr[2] != " ")
            {
                return arr[2]; // Return the winner symbol (X or O)
            }

            // Check for a tie (if no spaces remain and no winner)
            if (!arr.Contains(" "))
            {
                return "Tie"; // All spaces filled and no winner
            }

            return "No winner, next round"; // Game is still ongoing
        }




    }
}
