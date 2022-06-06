using System;

namespace ShootingDice
{
    public class SoreLoserException : Exception
    {
        public SoreLoserException(string message) : base(message)
        {

        }
    }
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player
    {
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
                System.Console.WriteLine($"You probably shouldn't invite {this.Name} back to game night . . .");
            }

        }
    }
}