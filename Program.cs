using System;

namespace Practice
{
    class Program { 
        static void Main(string[] args)
        {
            Grid grid = new Grid();

            while (!grid.isWhoseWin())
            {
                int[] position = { Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()) };

                grid.makeMove(position, 'X');
                grid.printGrid();
            }

            Console.Read();
        }
    }
}