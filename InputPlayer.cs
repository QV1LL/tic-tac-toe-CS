using System;

namespace Practice
{
    public class InputPlayer : Player
    {

        public InputPlayer(char symbol) : base(symbol)
        {

        }

        public int[] GetPosition()
        {
            int[] position = new int[2];

            while (true)
            {
                try
                {
                    position[1] = Convert.ToInt32(Console.ReadLine());
                    position[0] = Convert.ToInt32(Console.ReadLine());

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