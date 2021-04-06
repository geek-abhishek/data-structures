namespace DynamicProgramming
{
    public class WordSearch
    {
        public bool Exist(char[][] board, string word)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (board[i][j] == word[0]
                       && DFS(board, i, j, 0, word))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool DFS(char[][] board, int i, int j, int count, string word)
        {
            if (count == word.Length)
            {
                return true;
            }

            if (i < 0
                || j < 0
                || i >= board.Length
                || j >= board[0].Length
                || board[i][j] != word[count])
            {
                return false;
            }

            var temp = board[i][j];
            board[i][j] = ' ';

            var result = DFS(board, i + 1, j, count + 1, word)
                || DFS(board, i, j + 1, count + 1, word)
                || DFS(board, i - 1, j, count + 1, word)
                || DFS(board, i, j - 1, count + 1, word);

            board[i][j] = temp;
            return result;
        }
    }
}
