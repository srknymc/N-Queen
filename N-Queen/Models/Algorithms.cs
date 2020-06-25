using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace N_Queen.Models
{
    public static class Algorithms
    {
        public static Random rnd = new Random();
        public static (int[], int, int) HillClimbing(int n, int maxIterations)
        {
            int iteration = 0;

            int[] board = AppHelper.GenerateBoard(n);
            int targetCost = AppHelper.CalculateHeuristic(board);

            while (targetCost > 0 && iteration < maxIterations)
            {
                int tmpCost = targetCost;
                bool flag = false;

                for (int idxcol = 0; idxcol < n && !flag; ++idxcol)
                {
                    for (int idxrow = 0; idxrow < n && !flag; ++idxrow)
                    {
                        if (board[idxcol] != idxrow)
                        {
                            int[] newBoard = (int[])board.Clone();
                            newBoard[idxcol] = idxrow;

                            int cost = AppHelper.CalculateHeuristic(newBoard);
                            if (cost < targetCost)
                            {
                                board[idxcol] = idxrow;
                                targetCost = cost;
                                flag = true;
                            }
                        }
                    }
                }

                if (tmpCost == targetCost)
                {
                    board = AppHelper.GenerateBoard(n);
                }

                iteration++;
            }

            return (board, iteration, targetCost);
        }

        public static (int[],int,int) LocalBeamSearch(int n, int maxIterations, int numStates)
        {
            int iteration = 0;
            int[][] boards = new int[n * numStates][];
            int resultCost = -1;
            for (int i = 0; i < numStates; ++i)
            {
                int[] board = AppHelper.GenerateBoard(n);
                boards[i] = board;
            }

            while (iteration < maxIterations)
            {
                int[][] newBoards = new int[n * numStates][];


                for (int i = 0; i < numStates; ++i)
                {
                    int targetCost = AppHelper.CalculateHeuristic(boards[i]);
                    resultCost = targetCost;
                    if (targetCost == 0)
                    {
                        return (boards[i],iteration,resultCost);
                    }

                    for (int j = 0; j < n; ++j)
                    {
                        int[] copyBoard = new int[n];
                        boards[i].CopyTo(copyBoard, 0);
                        newBoards[i * n + j] = MakeMoveLBS(copyBoard, j, targetCost);
                        if (newBoards[i * n + j] == null)
                        {
                            newBoards[i * n + j] = AppHelper.GenerateBoard(n);
                        }
                    }
                }
                Dictionary<int, int> list = new Dictionary<int, int>();
                for (int i = 0; i < newBoards.Length; ++i)
                {
                    list.Add(i, AppHelper.CalculateHeuristic(newBoards[i]));
                }
                var tmp = list.ToList();
                tmp.Sort((x, y) => x.Value.CompareTo(y.Value));
                for (int i = 0; i < numStates; ++i)
                {
                    boards[i] = newBoards[tmp[i].Key];
                }
                iteration++;
                
            }
            return (boards[0],iteration,resultCost);
        }

        private static int[] MakeMoveLBS(int[] states, int col, int targetCost)
        {
            for (int i = 0; i < states.Length; ++i)
            {
                if (i != states[col])
                {
                    int tmpRow = states[col];
                    states[col] = i;

                    int cost = AppHelper.CalculateHeuristic(states);
                    if (targetCost > cost)
                    {
                        states[col] = i;
                        return states;
                    }

                    states[col] = tmpRow;
                }
            }

            return null;
        }
        public static (int[],int,int) SimulatedAnnealing(int n, int maxIteration, double temperature, double cFactor)
        {
            int[] board = AppHelper.GenerateBoard(n);
            int targetCost = AppHelper.CalculateHeuristic(board);
            int minCost = targetCost;
            int iteration = 0;
            while (targetCost > 0 && iteration < maxIteration)
            {
                board = MakeMoveSA(board, targetCost, temperature, minCost);
                targetCost = AppHelper.CalculateHeuristic(board);
                if (targetCost < minCost)
                {
                    minCost = targetCost;
                }
                temperature = Math.Max(temperature * cFactor, 0.5);
                iteration++;
            }
            return (board,iteration,targetCost);
        }

        private static int[] MakeMoveSA(int[] board, int targetCost, double temperature, int minCost)
        {
            while (true)
            {
                int col = rnd.Next(0, board.Length);
                int row = rnd.Next(0, board.Length);
                int tmp = board[col];
                double rand = rnd.NextDouble();
                board[col] = row;

                int newCost = AppHelper.CalculateHeuristic(board);
                if (newCost < minCost)
                    return board;
                int delta = minCost - newCost;
                double prob = Math.Exp(delta / temperature);
                if (rand < prob)
                    return board;
                board[col] = tmp;
            }
        }
    }
}
