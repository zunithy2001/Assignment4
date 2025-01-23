namespace Assignment4_4D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //compare two string without using string library functions.
            +

            // Input: Get two strings from the user
            Console.Write("Enter the first string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter the second string: ");
            string str2 = Console.ReadLine();

            // Initialize variables for comparison
            bool areEqual = true;

            // Check lengths first
            if (str1.Length != str2.Length)
            {
                areEqual = false;
            }
            else
            {
                // Compare each character
                for (int i = 0; i < str1.Length; i++)
                {
                    if (str1[i] != str2[i])
                    {
                        areEqual = false;
                        break;
                    }
                }
            }

            // Output the result
            if (areEqual)
            {
                Console.WriteLine("The strings are equal.");
            }
            else
            {
                Console.WriteLine("The strings are not equal.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();

        }
    }
}