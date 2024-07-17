using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Enemy : Player
    {
        public Enemy(char symbol) : base(symbol)
        {

        }

        public int[] getEnemyPosition(Grid currentGrid, char enemySymbol, char playerSymbol)
        {
            int[] getBestMove(char symbol)
            {
                Grid testGrid = currentGrid;
                int[] bestMove = new int[2] { -1, -1 };

                for (int i = 0; i < testGrid.grid.GetLength(0); i++)
                {

                    for (int j = 0; j < testGrid.grid.GetLength(1); j++)
                    {
                        int[] currentMove = { i + 1, j + 1 };

                        testGrid.makeMove(currentMove, symbol);

                        if (testGrid.getWinnerSymbol() == symbol)
                        {
                            bestMove = currentMove;
                        }

                        testGrid.grid[i, j] = testGrid.getEmpty();
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
                        if (currentGrid.grid[i, j] == currentGrid.getEmpty())
                        {
                            int[] currentMove = { i + 1, j + 1 };

                            moves.Add(currentMove);
                        }
                    }
                }

                return moves[random.Next(0, moves.Count - 1)];
            }

            return getRandomMove();
        }
    }
}