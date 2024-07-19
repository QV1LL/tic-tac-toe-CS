using System;

namespace Practice
{
    class Program { 

        static void Main(string[] args)
        {
            Grid grid = new Grid(); 

            Player player = new Player('X');
            Enemy enemy = new Enemy('0');

            char playerSymbol = player.Symbol;
            char enemySymbol = enemy.Symbol;

            while (Grid.getWinnerSymbol(grid.grid) == grid.getEmpty() && grid.isLeftMoves())
            {                
                if (grid.getTurn() % 2 == 1)
                {
                    grid.makeMove(player.getPosition(), playerSymbol);                
                    grid.printGrid();
                } else
                {
                    grid.makeMove(enemy.getEnemyPosition(grid.grid, enemySymbol, playerSymbol), enemySymbol);                    
                    grid.printGrid();
                }
            }

            char winner = Grid.getWinnerSymbol(grid.grid);

            
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

        public static bool ArraysEquals(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
                return false;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i]) 
                    return false;
            }

            return true;
        }

        public static bool ArraysEquals(char[] array1, char[] array2)
        {
            if (array1.Length != array2.Length)
                return false;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                    return false;
            }

            return true;
        }

        public static bool ArraysEquals(float[] array1, float[] array2)
        {
            if (array1.Length != array2.Length)
                return false;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                    return false;
            }

            return true;
        }
    }
}