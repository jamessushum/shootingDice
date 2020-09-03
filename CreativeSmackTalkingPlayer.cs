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

        public override int Roll()
        {

        }
    }
}