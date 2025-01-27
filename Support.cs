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