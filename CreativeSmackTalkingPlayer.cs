using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        List<string> Taunts = new List<string>(){
            "Hello There!",
            "So uncivilized . . .",
            "The negotiations were short.",
            "Why do I get the feeling that we've picked up another pathetic life form?"
        };
        public override int Roll()
        {
            System.Console.WriteLine($"{this.Name} says, \"{Taunts[new Random().Next(Taunts.Count)]}\"");
            return new Random().Next(DiceSize) + 1;
        }
    }
}