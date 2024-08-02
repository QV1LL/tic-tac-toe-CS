using System;

namespace Practice
{
    public abstract class Player
    {
        public char Symbol { get; private set; }


        public Player(char symbol)
        {
            this.Symbol = symbol;
        }
    }
}
