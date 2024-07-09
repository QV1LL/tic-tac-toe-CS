using System;
using System.Diagnostics;

namespace Practice
{
    class Program { 

        static void Main(string[] args)
        {
            Grid grid = new Grid(); 

            Player player = new Player('X');
            Enemy enemy = new Enemy('0');

            char playerSymbol = player.getSymbol();
            char enemySymbol = enemy.getSymbol();

            while (grid.getWinnerSymbol() == grid.getEmpty() && grid.isLeftMoves())
            {                
                if (grid.getTurn() % 2 == 0)
                {
                    grid.makeMove(player.getPosition(), playerSymbol);                
                    grid.printGrid();
                } else
                {
                    grid.makeMove(enemy.getEnemyPosition(grid, playerSymbol, enemySymbol), enemySymbol);                    
                    grid.printGrid();
                }
            }

            char winner = grid.getWinnerSymbol();

            
            if (winner == playerSymbol)
            {
                Console.WriteLine("YOU WON!");
            }
            else if (winner == enemySymbol)
            {
                Console.WriteLine("YOU LOSE!");
            } else
            {
                Console.WriteLine("DRAW!");
            }
             
            Console.ReadKey();            
        }
    }
}