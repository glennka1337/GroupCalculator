namespace GroupCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till miniräknaren! ");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Välj någon av nedanstående räkneoperatorer: ");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Avsluta ");

            int menuChoice = int.Parse(Console.ReadLine());


            bool run = true;

            while (run)
            {
                switch (menuChoice)
                {
                    case 1:
                        Addition();
                        break;

                    case 2:
                        Substraction();
                        break;

                    case 3:
                        Multiplication();
                        break;

                    case 4:
                        Division();
                        break;

                    default:
                        run = false;
                        break;

                }
            }


       
        }

        static void Multiplication()
        {
            Console.WriteLine("Ange två heltal:");
            int userInput1 = int.Parse(Console.ReadLine());
            int userInput2 = int.Parse(Console.ReadLine());
            int sum = userInput1 * userInput2;
            Console.WriteLine($"Svaret är: {sum}");
        }
    }
}
