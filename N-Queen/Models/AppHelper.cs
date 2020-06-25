using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Queen.Models
{
    static class AppHelper
    {
        public static Random rndGenerator = new Random();

        public static int[] GenerateBoard(int n) //generate random board with given n value
        {
            int[] board = new int[n];
            board = RandomizeBoard(board);
            return board;
        }

        public static int CalculateHeuristic(int[] board) //calculate cost. check row and diagonal
        {
            int h = 0;

            for (int i = 0; i < board.Length; ++i)
            {
                for (int j = 0; j < board.Length; ++j)
                {
                    if (i != j)
                    {
                        if(board[i] == board[j] || Math.Abs(board[i] - board[j]) == j - i)
                        {
                            h++;
                        }
                    }
                }
            }

            return h;
        }

        public static int[] RandomizeBoard(int[] board) //randomize board
        {
            for (int i = 0; i < board.Length; ++i)
            {
                board[i] = rndGenerator.Next(0, board.Length);
            }

            return board;
        }
    }
}
