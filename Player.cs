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
            int[] position = { Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()) };

            return position;
        }
    }
}
