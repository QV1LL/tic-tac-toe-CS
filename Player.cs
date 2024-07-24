using System;

namespace Practice
{
    class Player
    {
        public char Symbol { get; private set; }


        public Player(char symbol)
        {
            this.Symbol = symbol;
        }

        public virtual int[] getPosition()
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
