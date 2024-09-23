namespace GroupCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static void Subtraction()
        {
            Console.WriteLine("Ange två heltal: ");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            int userNum2 = Convert.ToInt32(Console.ReadLine());
            int difference = userNum1 - userNum2;

            Console.WriteLine($"Skillnaden blir: {difference}");
        }
    }
}
