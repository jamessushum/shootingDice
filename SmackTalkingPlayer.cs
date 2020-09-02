using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; set; }

        public string AddInsult(string insult)
        {
            return this.Taunt = insult;
        }

        public override int Roll()
        {
            // Return a random number between 1 and DiceSize and Insult
            Console.WriteLine($"{Name} says: {Taunt}");
            return new Random().Next(DiceSize) + 1;
        }
    }
}