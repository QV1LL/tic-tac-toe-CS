using System;
using System.Collections.Generic;

namespace Practice
{
    class Enemy : Player
    {
        public Enemy(char symbol) : base(symbol)
        {

        }

        public override int[] getPosition()
        {
            throw new ClosedMethodException("This method is not allowed in Enemys class");
        }

        public int[] getEnemyPosition(Grid currentGrid, char enemySymbol, char playerSymbol)
        {
            int[] getBestMove(char symbol)
            {
                char[,] testGrid = currentGrid.grid;

                int[] bestMove = new int[2] { -1, -1 };

                for (int i = 0; i < testGrid.GetLength(0); i++)
                {

                    for (int j = 0; j < testGrid.GetLength(1); j++)
                    {
                        if (testGrid[i, j] == ' ')
                        {
                            int[] currentMove = new int[2] { i + 1, j + 1 };

                            testGrid[i, j] = symbol;

                            if (Grid.getWinnerSymbol(testGrid) == symbol)
                                bestMove = currentMove;                            

                            testGrid[i, j] = Grid.empty;
                        }
                    }
                }

                return bestMove;
            }

            int[] getRandomMove()
            {
                Random random = new Random();
                List<int[]> moves = new List<int[]>();

                for (int i = 0; i < currentGrid.grid.GetLength(0); i++)
                {
                    for (int j = 0; j < currentGrid.grid.GetLength(1); j++)
                    {
                        if (currentGrid.grid[i, j] == Grid.empty)
                        {
                            int[] currentMove = { i + 1, j + 1 };

                            moves.Add(currentMove);
                        }
                    }
                }

                return moves[random.Next(0, moves.Count - 1)];
            }

            int[] emptyMove = new int[2] { -1, -1 };

            int[] playerBestMove = getBestMove(playerSymbol);
            int[] enemyBestMove = getBestMove(enemySymbol);            

            if (!Program.ArraysEquals(playerBestMove, emptyMove))                          
                return playerBestMove;            
            else if (!Program.ArraysEquals(enemyBestMove, emptyMove))          
                return enemyBestMove;            
            else
                return getRandomMove();
        }
    }
}