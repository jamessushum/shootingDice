using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.Write("Enter a roll number: ");
            int answer = Int32.Parse(Console.ReadLine());
            return answer;
        }
    }
}