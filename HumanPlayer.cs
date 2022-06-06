namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            int input = new int();
            do
            {
                System.Console.Write("Please enter a number: ");
            } while (!int.TryParse(System.Console.ReadLine(), out input));
            return input;
        }
    }
}