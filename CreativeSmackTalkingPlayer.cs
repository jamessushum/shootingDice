using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        List<string> listOfInsults = new List<string>()
        {
            "Go home, loser!",
            "Is that the best you got?",
            "Can I play someone better?",
            "Are we still on the practice round?"
        };

        // Roll selects and displays random taunt from list
        public override int Roll()
        {
            int randomNum = new Random().Next(0, 3);

            Console.WriteLine($"{Name} says: {listOfInsults[randomNum]}");

            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize) + 1;
        }
    }
}