namespace Assignment_5_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many numbers to print in reverse order: ");
            int printNumbers = int.Parse(Console.ReadLine());

            Console.WriteLine($"Numbers from {printNumbers} to 1 are:");
            PrintNumbers(printNumbers);
        }

        static void PrintNumbers(int n)
        {
            
            if (n < 1)
            {
                return;
            }

            // Print the current number
            Console.WriteLine(n);

            // Recursive case: call the function with n - 1
            PrintNumbers(n - 1);
        }
    }
}