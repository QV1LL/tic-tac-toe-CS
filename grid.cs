using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Grid
    {
        public char[,] grid = new char[3, 3];


        public Grid()
        {
            setupGrid();
        }

        private void setupGrid()
        {
            for (int i = 0; i < this.grid.GetLength(0); i++)
            {
                for (int j = 0; j < this.grid.GetLength(1); j++)
                {
                    this.grid[i, j] = ' ';
                }
            }
        }

        public void printGrid()
        {
            for (int i = 0; i < this.grid.GetLength(0); i++)
            {
                for (int j = 0; j < this.grid.GetLength(1); j++)
                {
                    Console.Write("|");
                    Console.Write(this.grid[i, j]);
                    Console.Write("|");
                }

                Console.WriteLine();
                if (i < this.grid.GetLength(0) - 1)
                    Console.WriteLine("---------");
            }
        }

        public void makeMove(int[] pos, char figure)
        {
            if (canMakeMove(pos))
                this.grid[pos[0] - 1, pos[1] - 1] = figure;
            else
                Console.WriteLine("This cell is already occupied or position is out of bounds!");
        }

        private bool canMakeMove(int[] pos)
        {         
            if (!(pos[0] <= this.grid.GetLength(1) && pos[1] <= this.grid.GetLength(0) && pos[0] >= 1 && pos[1] >= 1))
            {
                return false;
            }

            else if (this.grid[pos[0] - 1, pos[1] - 1] == ' ')
                return true;            

            return false;
        }

        public bool isWhoseWin ()
        {
            List<char> elements = new List<char>();

            foreach (char element in this.grid)
            {
                elements.Add(element);
            }

            return false;
        }
    }
}
