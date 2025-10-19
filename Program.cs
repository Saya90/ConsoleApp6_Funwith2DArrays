using System;
using System.Data.Common;

namespace ConsoleApp6_Funwith2DArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, Tell me how many fields do you want your board to have? Please type only numbers");
            Console.WriteLine("Columns:");
            int column = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Rows:");
            int row = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("You typed  " + column + " , "  + row);


            int[,] board = new int[row, column];  

            //const int GRID_VALUE = 1;
            //const int NEW_GRID_START = 1;
            int newGridv = 1;
            string border = "¦";
            const int NUMBER_WIDTH = 3; // z.B. 000 → 3 Stellen";
            string horizontal = new string('_', NUMBER_WIDTH); // passt zur Breite der Zahlen



            //if user chooses 4 columns , 3 rows --> total repetition is 12 times

            //Console.WriteLine(board[0, 0] = 1);
            //Console.WriteLine(board[0, 1] = 2);
            //Console.WriteLine(board[0, 2] = 3);
            //Console.WriteLine(board[0, 3] = 4);

            //Console.WriteLine(board[1, 0] = 5);
            //Console.WriteLine(board[1, 1] = 6);
            //Console.WriteLine(board[1, 2] = 7);
            //Console.WriteLine(board[1, 3] = 8);

            //Console.WriteLine(board[2, 0] = 9);
            //Console.WriteLine(board[2, 1] = 10);
            //Console.WriteLine(board[2, 2] = 11);
            //Console.WriteLine(board[2, 3] = 12);

            //while (columnIndex < column)
            //{ Console.Write("_"); }

            for (int i = 0; i < column; i++)
            {
                Console.Write($" {horizontal}");


            }
            Console.WriteLine();

            for (int rowIndex = 0; rowIndex < row; rowIndex++)
            {
                Console.Write(border);

                for (int columnIndex = 0; columnIndex < column; columnIndex++)
                {


                    board[rowIndex, columnIndex] = newGridv * newGridv;
                    Console.Write($"{board[rowIndex, columnIndex]:000}");

                    Console.Write(border);

                    newGridv++;
                                       
                }

                Console.WriteLine();
                }

            for (int i = 0; i < column; i++)
            {
                Console.Write($" {horizontal}");

            }

        }
    }
}


