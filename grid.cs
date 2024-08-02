using System;
using System.Collections.Generic;

namespace Practice
{
    public class Grid
    {
        public char[,] grid { get; private set; }

        private int turnCount;
        public int Turn {  get; private set; }

        public static char empty = ' '; 
        private static int[,] winPositions = {
            {0, 1, 2},
            {3, 4, 5}, 
            {6, 7, 8},
            {0, 3, 6},
            {1, 4, 7},
            {2, 5, 8},
            {0, 4, 8},
            {2, 4, 6},
        };


        public Grid()
        {
            setupGrid();
        }

        private void setupGrid()
        {
            this.grid = new char[3, 3];
            this.Turn = 1;
            turnCount = this.grid.GetLength(0) * this.grid.GetLength(1);

            for (byte i = 0; i < this.grid.GetLength(0); i++)
            {
                for (byte j = 0; j < this.grid.GetLength(1); j++)
                {
                    this.grid[i, j] = empty;
                }
            }
        }

        public void PrintGrid()
        {
            Console.WriteLine();

            for (byte i = 0; i < this.grid.GetLength(0); i++)
            {
                for (byte j = 0; j < this.grid.GetLength(1); j++)
                {
                    Console.Write("|");
                    Console.Write(this.grid[i, j]);
                    Console.Write("|");
                }

                Console.WriteLine();
                if (i < this.grid.GetLength(0) - 1)
                    Console.WriteLine("---------");
            }
            
            Console.WriteLine();
        }

        public void MakeMove(int[] pos, char symbol)
        {
            if (canMakeMove(pos))
            {
                this.grid[pos[0] - 1, pos[1] - 1] = symbol;
                this.Turn++;
            }                
            else
                Console.WriteLine("This cell is already occupied or position is out of bounds!");
        }

        private bool canMakeMove(int[] pos)
        {         
            if (!(pos[0] <= this.grid.GetLength(1) && pos[1] <= this.grid.GetLength(0) && pos[0] >= 1 && pos[1] >= 1) || this.grid[pos[0] - 1, pos[1] - 1] != ' ')
            {
                return false;
            }

            return true;
        }

        public static char GetWinnerSymbol(char[,] grid)
        {         
            List<char> elements = new List<char>();

            foreach (char element in grid)
            {
                elements.Add(element);
            }

            for (int i = 0; i < winPositions.GetLength(0); i++)
            {
                char element = elements[winPositions[i, 0]];
                bool winState = true;

                if (element == Grid.empty)
                    continue;

                for (int j = 0; j < winPositions.GetLength(1); j++)
                {
                    char currentElement = elements[winPositions[i, j]];

                    if (element != currentElement)
                    {
                        winState = false;
                        break;
                    }                                       
                }

                if (winState)
                    return element;
            }

            return Grid.empty;
        }  

        public bool IsLeftMoves ()
        {
            return this.Turn <= this.turnCount;
        }
    }
}
