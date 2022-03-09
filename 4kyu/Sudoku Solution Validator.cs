using System;

namespace _4kyu
{
    public class Kata14
    {
        // https://www.codewars.com/kata/529bf0e9bdf7657179000008
        // Write a function ValidateSolution that accepts a 2D array representing a Sudoku board, and returns true if it is a valid solution, or false otherwise. The cells of the sudoku board may also contain 0's, which will represent empty cells. Boards containing one or more zeroes are considered to be invalid solutions.
        public class Sudoku
        {
            public static bool ValidateSolution(int[][] board)
            {
                int squareLength = Convert.ToInt32(Math.Sqrt(board.Length));

                for (int i = 0; i < board.Length; i++)
                {
                    var checkedRow = new bool[board.Length + 1];
                    var checkedColumn = new bool[board.Length + 1];
                    var checkedSquare = new bool[board.Length + 1];

                    for (int j = 0; j < board.Length; j++)
                    {
                        int boardValue = board[i][j];
                        if (checkedRow[boardValue]) return false;
                        checkedRow[boardValue] = true;

                        boardValue = board[j][i];
                        if (checkedColumn[boardValue]) return false;
                        checkedColumn[boardValue] = true;

                        int squareCoordinateX = squareLength * (i / squareLength);
                        int squareCoordinateY = squareLength * (i % squareLength);

                        boardValue = board[(j % 3) + squareCoordinateX][(j / 3) + squareCoordinateY];
                        if (checkedSquare[boardValue]) return false;
                        checkedSquare[boardValue] = true;
                    }
                }

                return true;
            }
        }
    }
}