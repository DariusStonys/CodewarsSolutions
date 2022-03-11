using System;

namespace Kyu4
{
    public class Kata5
    {
        // https://www.codewars.com/kata/540afbe2dc9f615d5e000425
        // Given a Sudoku data structure with size NxN, N > 0 and √N == integer, write a method to validate if it has been filled out correctly.
        // Data structure dimension: NxN where N > 0 and √N == integer. Rows may only contain integers: 1..N(N included). Columns may only contain integers: 1..N(N included). 'Little squares' (3x3 in example above) may also only contain integers: 1..N(N included)
        public class Sudoku
        {
            private readonly int[][] board;
            private readonly int boardLength;
            private readonly int squareLength;

            public Sudoku(int[][] sudokuData)
            {
                board = sudokuData;
                boardLength = sudokuData.Length;
                squareLength = Convert.ToInt32(Math.Sqrt(sudokuData.Length));
            }

            public bool IsValid()
            {
                for (int i = 0; i < boardLength; i++)
                {
                    var checkedRow = new bool[boardLength + 1];
                    var checkedColumn = new bool[boardLength + 1];
                    var checkedSquare = new bool[boardLength + 1];

                    for (int j = 0; j < boardLength; j++)
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

                return false;
            }
        }
    }
}