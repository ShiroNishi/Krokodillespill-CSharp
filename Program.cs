namespace Krokodillespill
{
    internal class Program
    {
        static int number1;
        static int number2;
        static int points = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Krokodillespill");
            Run();
        }
        static void Run()
        {
            number1 = RandomNum();
            number2 = RandomNum();
            Console.WriteLine($"{number1}_{number2}");
            Console.WriteLine("Skriv <, > eller =");
            CheckInput();
            Run();
        }

        static public int RandomNum()
        {
            return new Random().Next(1, 11);
        }

        static public void CheckInput()
        {
            var input = Console.ReadLine();
            //Console.WriteLine(input);
            if (input != "<" && input != ">" && input != "=")
            { 
                GameOver();
            }
            else
            {
                var result = input switch
                {
                    "=" when (number1 == number2) => points += 1,
                    ">" when (number1 > number2) => points += 1,
                    "<" when (number1 < number2) => points += 1,
                    _ => points -= 1,
                };

                Console.WriteLine($"Poeng: {points}");
            }
        }
        static void GameOver()
        {
            Console.WriteLine("Ugyldig tegn. Spillet avsluttes.");
            Environment.Exit(0);
        }
    }
}
