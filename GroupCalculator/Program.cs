namespace GroupCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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
