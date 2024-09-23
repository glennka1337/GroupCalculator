namespace GroupCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
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
