namespace Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine()), num2 = Convert.ToInt32(Console.ReadLine()), temp = 0;
            temp = num1;
            num1 = num2;
            num2 = temp;   
            Console.WriteLine($"After swapping num1= {num1}, num2 = {num2}");
            Console.ReadLine();
        }
    }
}