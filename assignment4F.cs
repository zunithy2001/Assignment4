namespace Assignment4_6F
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //extract a substring from a given string without using the library function 

            // Getting a user input as a string 
            Console.Write("Enter the main string: ");
            string mainString = Console.ReadLine();

            // Getting starting position of the substring
            Console.Write("Enter the starting position (0-based index): ");
            int startPosition;

            //validating
            while (!int.TryParse(Console.ReadLine(), out startPosition) || startPosition < 0 || startPosition >= mainString.Length)
            {
                Console.WriteLine("Invalid input! Please enter a valid starting position within the string range.");
            }

            // Getting starting length of the substring

            Console.Write("Enter the length of the substring: ");
            int length;

            //validating
            while (!int.TryParse(Console.ReadLine(), out length) || length < 0 || startPosition + length > mainString.Length)
            {
                Console.WriteLine("Invalid input! Please enter a valid length.");
            }

            // Extract substring
            char[] substring = new char[length];
            for (int i = 0; i < length; i++)
            {
                substring[i] = mainString[startPosition + i];
            }

            // Displaying the result
            Console.Write("Extracted Substring: ");
            foreach (char ch in substring)
            {
                Console.Write(ch);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();
        }
    }
}
