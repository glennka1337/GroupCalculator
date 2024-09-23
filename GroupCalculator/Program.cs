namespace GroupCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till miniräknaren! ");
            Console.ReadKey();
            Console.Clear();



            bool run = true;

            while (run)
            {
            Console.WriteLine("Välj någon av nedanstående räkneoperatorer: ");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Avsluta ");

            int menuChoice = int.Parse(Console.ReadLine());

                switch (menuChoice)
                {
                    case 1:
                        Console.Clear();
                        Addition();
                        break;

                    case 2:
                        Console.Clear();
                        Subtraction();
                        break;

                    case 3:
                        Console.Clear();
                        Multiplication();
                        break;

                    case 4:
                        Console.Clear();
                        Division();
                        break;

                    default:
                        Console.Clear();
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

        static void Division()
        {
            Console.WriteLine("Ange två heltal:");
            int userInput1 = int.Parse(Console.ReadLine());
            int userInput2 = int.Parse(Console.ReadLine());
            int sum = userInput1 / userInput2;
            Console.WriteLine($"Svaret är: {sum}");
        }

        static void Subtraction()
        {
            Console.WriteLine("Ange två heltal: ");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            int userNum2 = Convert.ToInt32(Console.ReadLine());
            int difference = userNum1 - userNum2;

            Console.WriteLine($"Skillnaden blir: {difference}");
        }

        static void Addition()
        {
            Console.WriteLine("Ange två heltal: ");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            int userNum2 = Convert.ToInt32(Console.ReadLine());
            int sum = userNum1 + userNum2;

            Console.WriteLine($"Summan blir: {sum}");
        }
    }
}
