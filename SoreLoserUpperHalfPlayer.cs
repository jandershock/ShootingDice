using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : Player
    {
        public override int Roll()
        {
            // Return a random number between 1 and DiceSize
            return new Random().Next(DiceSize / 2, DiceSize) + 1;
        }


        public override void Play(Player other)
        {
            // Call roll for "this" object and for the "other" object
            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");

            try
            {
                if (myRoll > otherRoll)
                {
                    Console.WriteLine($"{Name} Wins!");
                }
                else if (myRoll < otherRoll)
                {
                    throw new SoreLoserException($"{this.Name} says, \"I don't want to play this game anymore . . .\"");
                }
                else
                {
                    // if the rolls are equal it's a tie
                    Console.WriteLine("It's a tie");
                }
            }
            catch (SoreLoserException ex)
            {
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine($"Wow, {this.Name} cheated and still lost . . .");
            }

        }
    }
}