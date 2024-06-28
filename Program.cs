using System;

namespace Practice
{
    class Program { 
        static void Main(string[] args)
        {
            Grid grid = new Grid();

            int[] position = { Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()) };

            grid.makeMove(position, 'X');
            grid.printGrid();

            position[0] = Convert.ToInt32(Console.ReadLine()); position[1] = Convert.ToInt32(Console.ReadLine());

            grid.makeMove(position, 'X');
            grid.printGrid();

            Console.Read();
        }
    }
}