using System;

namespace Practice
{
    class Program { 
        static void Main(string[] args)
        {
            Grid grid = new Grid();
            Player player1 = new Player('0');
            Player player2 = new Player('X');

            while (!grid.isWhoseWin())
            {                
                grid.makeMove(player1.getPosition(), player1.getSymbol());
                grid.printGrid();
            }
        }
    }
}