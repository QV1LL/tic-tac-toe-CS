using System;

namespace Practice
{
    public class HumanPlayer : Player
    {

        public HumanPlayer(char symbol) : base(symbol)
        {

        }

        public int[] GetPosition()
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