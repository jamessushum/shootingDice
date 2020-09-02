using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; set; }

        // Method to add insult
        public string AddInsult(string insult)
        {
            return this.Taunt = insult;
        }

        public override int Roll()
        {
            // Displays taunt on every roll
            // Return a random number between 1 and DiceSize
            Console.WriteLine($"{Name} says: {Taunt}");
            return new Random().Next(DiceSize) + 1;
        }
    }
}