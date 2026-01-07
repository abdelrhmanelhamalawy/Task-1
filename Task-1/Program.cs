namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  Islam's Carpet Cleaning Service\nCharges:\n  " +
                " $25 per small\n   $35 per large\nSales tax rate is 6%" +
                "\nEstimates are valid for 30 days\n");

            Console.WriteLine("enter number of small carpet :");
            int small = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number of large carpet :");
            int large = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("price for small room : 25$ ");
            Console.WriteLine("price for large room : 35$ ");
            double cost = (small * 25) + (large * 35);
            double tax = (cost * 6) / 100;
            
            Console.WriteLine($"cost ={cost} $ ");
            Console.WriteLine($"tax = {tax} $");
            Console.WriteLine("========================== ");
            Console.WriteLine($"Total estimate: {cost + tax } $ \nThis estimate is valid for 30 days\n");


        }
    }
}
