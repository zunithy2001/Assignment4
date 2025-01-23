namespace Assignment4_3C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // count the total number of words in a string 

            // Getting the string from the user
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            // Declaring variables
            int wordCount = 0;
            bool isWord = false;

            // Traverse each character of the string
            for (int i = 0; i < input.Length; i++)
            {
                // loop to check if the character is not a space (part of a word)
                if (input[i] != ' ' && !isWord)
                {
                    isWord = true;
                    wordCount++;
                }
                // Check if the character is a space (end of a word)
                else if (input[i] == ' ' && isWord)
                {
                    isWord = false;
                }
            }

            // Output the total word count
            Console.WriteLine($"The total number of words in the string is: {wordCount}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}