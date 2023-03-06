using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_3
{
    class KnightTour
    {
        private static readonly int[,] moves = new int[,] {
        { 2, 1 }, { 1, 2 }, { -1, 2 }, { -2, 1 },
        { -2, -1 }, { -1, -2 }, { 1, -2 }, { 2, -1 }
    };

        private int[,] board;
        private int boardSize;
        private bool solutionFound;

        public KnightTour(int boardSize)
        {
            this.boardSize = boardSize;
            board = new int[boardSize, boardSize];
        }

        public void Solve()
        {
            VisitSquare(0, 0);
            TryNextMove(0, 0, 1);
        }

        private void VisitSquare(int row, int col)
        {
            board[row, col] = 1; // mark as visited
        }

        private bool IsValidMove(int row, int col)
        {
            return row >= 0 && row < boardSize &&
                   col >= 0 && col < boardSize &&
                   board[row, col] == 0;
        }

        private void TryNextMove(int row, int col, int moveNumber)
        {
            if (moveNumber == boardSize * boardSize)
            {
                solutionFound = true;
                PrintSolution();
                return;
            }

            for (int i = 0; i < moves.GetLength(0); i++)
            {
                int nextRow = row + moves[i, 0];
                int nextCol = col + moves[i, 1];

                if (IsValidMove(nextRow, nextCol))
                {
                    VisitSquare(nextRow, nextCol);
                    TryNextMove(nextRow, nextCol, moveNumber + 1);
                    if (solutionFound) return; // stop searching if a solution is found
                    board[nextRow, nextCol] = 0; // unmark as visited (backtracking)
                }
            }
        }

        private void PrintSolution()
        {
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    Console.Write("{0,3}", board[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
