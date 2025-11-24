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
            //const int GRID_VALUE = 1;
            //const int NEW_GRID_START = 1;
            int newGridv = 1;
            string border = "¦";
            const int NUMBER_WIDTH = 3; // z.B. 000 → 3 Stellen";
            string horizontal = new string('_', NUMBER_WIDTH); // passt zur Breite der Zahlen



            Console.WriteLine("Hi, Tell me how many fields do you want your board to have? Please type only numbers");
            Console.WriteLine("Columns:");
            int column = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Rows:");
            int row = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("You typed  " + column + " , "  + row);

            Console.WriteLine("Choose a specific mode for example 1 for sequential numbers ; 2 for only even numbers; 3 for exponential numbers = n²");
            int mode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You chose option " + mode);

            int[,] board = new int[row, column];

            for (int i = 0; i < column; i++)
            {
                Console.Write($" {horizontal}");
            }
            Console.WriteLine();


            for (int rowIndex = 0; rowIndex < row; rowIndex++)
            {

                for (int columnIndex = 0; columnIndex < column; columnIndex++)
                {

                    if (mode == SEQ_NUM)
                    {
                        board[rowIndex, columnIndex] = newGridv;
                    }

                    else if (mode == EVEN_NUM)
                    {
                        board[rowIndex, columnIndex] = newGridv * 2;
                    }

                    else if (mode == EXP_NUM)
                    {

                        board[rowIndex, columnIndex] = newGridv * newGridv;

                        newGridv++;
                    }
                    

                    else if (mode != EXP_NUM && mode != SEQ_NUM && mode != EVEN_NUM)
                    {

                        
                        Console.Write("Please only choose from the given options.");

                        break;

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


            for (int i = 0; i < column; i++)
            {
                Console.Write($" {horizontal}");

            }

        }



    }
}

