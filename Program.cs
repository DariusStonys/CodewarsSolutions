using _4kyu;
using _5kyu;
using System;
using System.Diagnostics;

class TestSpace
{
    static void Main()
    {
        //var input = Convert.ToInt32(Console.ReadLine());
        //var input = Console.ReadLine();

        var input = new int[][]
        {
            new int[] {0}
        };

        int[][] board;
        int boardLength;
        int squareLength;

        Stopwatch sw = new Stopwatch();
        sw.Start();

        Sudoku(input);
        var result = IsValid();

        Console.WriteLine("Result: {0}", result);
        //foreach (var item in result) Console.WriteLine(item);

        sw.Stop();
        Console.WriteLine("Time taken: {0}", sw.Elapsed);
        Console.ReadKey();
        
        void Sudoku(int[][] sudokuData)
        {
            board = sudokuData;
            boardLength = sudokuData.Length;
            squareLength = Convert.ToInt32(Math.Sqrt(sudokuData.Length));
        }

        bool IsValid()
        {
            for (int i = 0; i < boardLength; i++)
            {
                var checkedRow = new bool[boardLength + 1];
                var checkedColumn = new bool[boardLength + 1];
                var checkedSquare = new bool[boardLength + 1];

                for (int j = 0; j < boardLength; j++)
                {
                    int boardValue = board[i][j];
                    if (boardValue == 0 || boardValue > boardLength) return false;

                    if (checkedRow[boardValue]) return false;
                    checkedRow[boardValue] = true;

                    boardValue = board[j][i];
                    if (checkedColumn[boardValue]) return false;
                    checkedColumn[boardValue] = true;

                    int squareCoordinateX = squareLength * (i / squareLength);
                    int squareCoordinateY = squareLength * (i % squareLength);

                    boardValue = board[(j % squareLength) + squareCoordinateX][(j / squareLength) + squareCoordinateY];
                    if (checkedSquare[boardValue]) return false;
                    checkedSquare[boardValue] = true;
                }
            }

            return true;
        }
    }    
}