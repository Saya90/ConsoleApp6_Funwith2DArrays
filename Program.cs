using System;
using System.Data.Common;

namespace ConsoleApp6_Funwith2DArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int SEQ_NUM = 1;
            const int EVEN_NUM = 2;
            const int EXP_NUM = 3;
            const int EVEN_MULTIPLIER = 2;
            const int NUMBER_WIDTH = 3; // z.B. 000 → 3 Stellen";

            //const int GRID_VALUE = 1;
            //const int NEW_GRID_START = 1;
            string border = "¦";
            string horizontal = new string('_', NUMBER_WIDTH); // passt zur Breite der Zahlen


            //Console.WriteLine("Hi, Tell me how many fields do you want your board to have? Please type only numbers");
            Console.WriteLine("Columns:");
            //int column = Convert.ToInt32(Console.ReadLine());

            int column;
            while (true)
            {
                Console.Write("Enter a number: ");

                bool isInt = int.TryParse(Console.ReadLine(), out column);

                if (isInt)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

            }

            Console.WriteLine("Rows:");
            //int row = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("You typed  " + column + " , "  + row);

            int row;
            while (true)
            {
                Console.Write("Enter a number: ");

                bool isInt = int.TryParse(Console.ReadLine(), out row);

                if (isInt)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

            }

            Console.WriteLine("Choose a specific mode for example 1 for sequential numbers ; 2 for only even numbers; 3 for exponential numbers = n²");
            //int mode = Convert.ToInt32(Console.ReadLine());

            int mode;
            while (true)
            {
                Console.Write("Enter a number: ");

                bool isInt = int.TryParse(Console.ReadLine(), out mode);

                if (isInt)
                {
                    if (mode < 4)

                        break;

                    else


                    {
                        Console.WriteLine("Invalid input. Please enter a valid number from 1 to 3.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

            }
            Console.WriteLine($"You chose option " + mode);


            int newGridv = 1;
            int[,] board = new int[row, column];

            for (int i = 0; i < column; i++)
            {
                Console.Write($" {horizontal}");
            }
            Console.WriteLine();

            if (mode != EXP_NUM && mode != SEQ_NUM && mode != EVEN_NUM)
            {

                Console.WriteLine("Please only choose from the given options.");

            }

            //for (int rowIndex = 0; rowIndex < row; rowIndex++)
            //{

            //    for (int columnIndex = 0; columnIndex < column; columnIndex++)
            //    {

            //        if (mode == SEQ_NUM)
            //        {
            //            board[rowIndex, columnIndex] = newGridv;
            //        }

            //        else if (mode == EVEN_NUM)
            //        {
            //            board[rowIndex, columnIndex] = newGridv * EVEN_MULTIPLIER;
            //        }

            //        else if (mode == EXP_NUM)
            //        {
            //            board[rowIndex, columnIndex] = newGridv * newGridv;
            //        }

            //        newGridv++;
            //    }

            //}

            if (mode == SEQ_NUM)
            {

                for (int rowIndex = 0; rowIndex < row; rowIndex++)
                {

                    for (int columnIndex = 0; columnIndex < column; columnIndex++)
                    {
                        board[rowIndex, columnIndex] = newGridv;
                        newGridv++;

                    }
                }
            }

            else if (mode == EVEN_NUM)
            {
                for (int rowIndex = 0; rowIndex < row; rowIndex++)
                {
                    for (int columnIndex = 0; columnIndex < column; columnIndex++)

                    {
                    board[rowIndex, columnIndex] = newGridv * EVEN_MULTIPLIER;
                        newGridv++;
                    }
                }
            }
            else if (mode == EXP_NUM)
            {
                for (int rowIndex = 0; rowIndex < row; rowIndex++)
                {

                    for (int columnIndex = 0; columnIndex < column; columnIndex++)
                    {

                        board[rowIndex, columnIndex] = newGridv * newGridv;
                        newGridv++;

                    }

                }

            }

            for (int rowIndex = 0; rowIndex < row; rowIndex++)
            {
                Console.Write(border);

                for (int columnIndex = 0; columnIndex < column; columnIndex++)
                {

                    Console.Write($"{board[rowIndex, columnIndex]:000}");

                    Console.Write(border);

                }

                if (rowIndex < row - 1)
                {
                    Console.WriteLine();
                }

            }

            Console.WriteLine() ;

            for (int i = 0; i < column; i++)
            {
                Console.Write($" {horizontal}");

            }

        }



    }
}
