using System;

namespace Practice
{
    class Program { 

        static void Main(string[] args)
        {
            Grid grid = new Grid(); 
            Random random = new Random();

            int randomNumber = random.Next();

            InputPlayer player = new InputPlayer((randomNumber % 2 == 1) ? 'X' : 'O');
            EnemyPlayer enemy = new EnemyPlayer((player.Symbol == 'X') ? 'O' : 'X');

            char playerSymbol = player.Symbol;
            char enemySymbol = enemy.Symbol;

            while (Grid.GetWinnerSymbol(grid.grid) == Grid.empty && grid.IsLeftMoves())
            {                
                if (grid.Turn % 2 == randomNumber % 2)
                {
                    grid.MakeMove(player.GetPosition(), playerSymbol);                
                    grid.PrintGrid();
                } else
                {
                    grid.MakeMove(enemy.GetPosition(grid, enemySymbol, playerSymbol), enemySymbol);                    
                    grid.PrintGrid();
                }
            }

            char winner = Grid.GetWinnerSymbol(grid.grid);

            
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