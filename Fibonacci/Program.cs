namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num1 = 0, num2 = 1, nextNum, length;
                Console.Write("Enter the number of elements to Print : ");
                length = int.Parse(Console.ReadLine());
                if (length < 2)
                {
                    Console.Write("Please Enter a number greater than two");
                }
                else
                {
                    Console.Write(num1 + " " + num2 + " ");
                    for (int i = 2; i < length; i++)
                    {
                        nextNum = num1 + num2;
                        Console.Write(nextNum + " ");
                        num1 = num2;
                        num2 = nextNum;
                    }
                }

                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("Something bad happened.");
                throw;
            }            
        }
    }
}