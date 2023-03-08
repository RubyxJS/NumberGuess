namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int answer = random.Next(1, 10);
            Console.WriteLine("Guess a number between 1 nad 10 !");
            Console.WriteLine("You have 5 guesses O_O");

            int[] guesses = new int[5];

            foreach (int guess in guesses)
            {
                guesses[guess] = Int32.Parse(Console.ReadLine());
                if (guesses[guess] == answer)
                {
                    Console.WriteLine(" You guessed right!");
                    break;
                }
                else
                {
                    Console.WriteLine("Try again!");
                }

            }
            Console.WriteLine("The right number was " + answer);

        }
    }
}