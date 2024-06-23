namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            var winNum = r.Next(0, 10);

            bool win = false;

            do
            {
                Console.Write("Guess a number inbetwenn 0 and 100: ");

                string s = Console.ReadLine();

                int i = int.Parse(s);

                if (i > winNum)
                {
                    Console.WriteLine("To high! Guess Lower.....");
                }
                else if (i < winNum)
                {
                    Console.WriteLine("Too low! Guess Higher....");
                }
                else if (i == winNum)
                {
                    Console.Write("Congratulations");
                    win = true;
                }

                Console.WriteLine();

            } while (win == false);

            Console.WriteLine("Thank You for playing the game");
            Console.WriteLine("Press any key to finish");
            Console.ReadKey(true);
        }
    }
}