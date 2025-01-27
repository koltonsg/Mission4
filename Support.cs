namespace Mission4
{
    internal class Support
    {
        public void PrintBoard(string[,] arr)
        {
            Console.WriteLine("Tic-Tac-Toe Board:");
            
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++) 
                {
                    Console.Write(arr[i, j]); 
                    if (j < arr.GetLength(1) - 1) Console.Write(" | "); // Add a separator between columns
                } 
                Console.WriteLine();
                
                if (i < arr.GetLength(0) -1) Console.WriteLine("---------"); // Add a separator between rows
            }
        }

        public string ValidWinner(string[] arr)
        {
            
        }
        
        public bool CheckRowForWin(char[][] board, int rowIndex)
        {
            char firstCell = board[rowIndex][0];
            if (firstCell == '-') return false;

            for (int col = 1; col < 3; col++)
            {
                if (board[rowIndex][col] != firstCell)
                    return false;
            }
            return true;
        }
        
        
        
    }
}