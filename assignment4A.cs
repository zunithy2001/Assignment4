namespace Assignment4_1A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //find the length of a string without using library function. 

            // Getting user input as the string
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Find the length manually
            int length = 0;

            // Loop through each character until the end of the string
            foreach (char c in input)
            {
                length++;
            }

            // Display the length of the string
            Console.WriteLine($"The length of the string is: {length}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();

        }
    }
}
