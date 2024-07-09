using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Player
    {
        private char symbol;


        public Player(char symbol)
        {
            this.symbol = symbol;
        }

        public char getSymbol() { return symbol; }

        public int[] getPosition()
        {
            int[] position = new int[2];

            while (true)
            {
                try
                {
                    position[0] = Convert.ToInt32(Console.ReadLine());
                    position[1] = Convert.ToInt32(Console.ReadLine());

                    break;
                }
                catch (FormatException exception)
                {
                    Console.WriteLine("Incorrect format");
                }
            }

            return position;
        }        
    }
}
