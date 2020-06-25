using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace N_Queen.Models
{
    //Algorithm Class
    public static class Algorithms
    {
        public static Random rnd = new Random(); //random var for operations
        public static (int[], int, int) HillClimbing(int n, int maxIterations) // Hill Climbing Algorithm Main Code
        {
            int iteration = 0; // iteration var for loop

            int[] board = AppHelper.GenerateBoard(n); //Generating random board 
            int targetCost = AppHelper.CalculateHeuristic(board); // calculating cost value for board

            while (targetCost > 0 && iteration < maxIterations) // while cost greater than 0 and iteration less than given max iteration parameter
            {
                int tmpCost = targetCost; //to check new state tmp
                bool flag = false; //to check solution find

                for (int idxcol = 0; idxcol < n && !flag; ++idxcol) //coloumn index
                {
                    for (int idxrow = 0; idxrow < n && !flag; ++idxrow) // row index
                    {
                        if (board[idxcol] != idxrow) //dont need to check same index
                        {
                            int[] newBoard = (int[])board.Clone(); //copy board
                            newBoard[idxcol] = idxrow; //move queen

                            int cost = AppHelper.CalculateHeuristic(newBoard); //check new cost 
                            if (cost < targetCost) // if new cost is better change next state to current state
                            {
                                board[idxcol] = idxrow;
                                targetCost = cost;
                                flag = true;
                            }
                        }
                    }
                }

                if (tmpCost == targetCost) // if costs are equeal  randomize board
                {
                    board = AppHelper.GenerateBoard(n);
                }

                iteration++;
            }

            return (board, iteration, targetCost); 
        }

        public static (int[],int,int) LocalBeamSearch(int n, int maxIterations, int numStates)//Local Beam Search Main code
        {
            int iteration = 0;//iteration val for loop
            int[][] boards = new int[n * numStates][];//generating 2d array for given #State
            int resultCost = -1;
            for (int i = 0; i < numStates; ++i) //generating states
            {
                int[] board = AppHelper.GenerateBoard(n);
                boards[i] = board;
            }

            while (iteration < maxIterations) //while iteration less than given max iteration
            {
                int[][] newBoards = new int[n * numStates][]; // creating new board to check new state


                for (int i = 0; i < numStates; ++i) 
                {
                    int targetCost = AppHelper.CalculateHeuristic(boards[i]); //calculate current cost
                    resultCost = targetCost; //to check newstate cost
                    if (targetCost == 0)//if cost =0 it means solution found
                    {
                        return (boards[i],iteration,resultCost); //return state
                    }

                    for (int j = 0; j < n; ++j) //Move queens and check states cost. these will sort and select first #State 
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

                Dictionary<int, int> list = new Dictionary<int, int>();//for sorting key is index value is calculated cost
                for (int i = 0; i < newBoards.Length; ++i)
                {
                    list.Add(i, AppHelper.CalculateHeuristic(newBoards[i])); //adding list with costs
                }
                var tmp = list.ToList();
                tmp.Sort((x, y) => x.Value.CompareTo(y.Value)); //sort list
                for (int i = 0; i < numStates; ++i) // set to current state with best calculated cost
                {
                    boards[i] = newBoards[tmp[i].Key];
                }
                iteration++;
                
            }
            return (boards[0],iteration,resultCost); // return best
        }

        private static int[] MakeMoveLBS(int[] states, int col, int targetCost)
        {
            //Move queens then check cost if its ok sort and assing as current state
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
        public static (int[],int,int) SimulatedAnnealing(int n, int maxIteration, double temperature, double cFactor) // Simulated Annealing Algorithm main code
        {
            int[] board = AppHelper.GenerateBoard(n); // generate random board 
            int targetCost = AppHelper.CalculateHeuristic(board);//calculate current cost
            int minCost = targetCost; //to check delta and prob
            int iteration = 0;
            while (targetCost > 0 && iteration < maxIteration)
            {
                board = MakeMoveSA(board, targetCost, temperature, minCost); //make move 
                targetCost = AppHelper.CalculateHeuristic(board);
                if (targetCost < minCost)
                {
                    minCost = targetCost;
                }
                temperature = Math.Max(temperature * cFactor, 0.5); //reduce temp for threshold 0.5
                iteration++;
            }
            return (board,iteration,targetCost);
        }

        private static int[] MakeMoveSA(int[] board, int targetCost, double temperature, int minCost)
        {
            while (true)
            {
                int col = rnd.Next(0, board.Length);//get random col index
                int row = rnd.Next(0, board.Length);//get random row index
                int tmp = board[col]; //store old value
                double rand = rnd.NextDouble();//create random for prob
                board[col] = row; //make changes with the random indicies

                int newCost = AppHelper.CalculateHeuristic(board); //calculate new cost
                if (newCost < minCost) //if new state is better assing it as current state
                    return board;
                int delta = minCost - newCost; //calculate delta
                double prob = Math.Exp(delta / temperature); // calculate prob
                if (rand < prob) //check prob and make it current state
                    return board;
                board[col] = tmp; //return old state
            }
        }
    }
}
