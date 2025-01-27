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
                if (arr[i] == arr[i + 3] && arr[i + 3] == arr[i + 6])
                {
                    winner = arr[i + 3].ToString();
                    return winner;
                }
            }
        
            //check diagonal
            if (arr[0] == arr[4] && arr[4] == arr[8])
            {
                winner = arr[4].ToString();
                return winner;
            }
            else if (arr[2] == arr[4] && arr[4] == arr[6])
            {
                winner = arr[4].ToString();
                return winner;
            }

            return ("No winner, next round");
            
        }
        
        
        
    }
}