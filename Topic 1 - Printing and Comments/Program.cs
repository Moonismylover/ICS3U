using Microsoft.VisualBasic;

namespace Topic_1___Printing_and_Comments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.Writeline(); = print()
            Console.WriteLine("Hello, World!");

            // Colours the text red
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("My name is Angel.");
            Console.WriteLine(" ");

            // Console.Write does not add move the cursor to the next line
            Console.Write("Computers");

            // Console.WriteLine adds a new line after printing
            Console.WriteLine(" Rule!");

            Console.WriteLine("Press ENTER to continue...");

            // Pauses the program until the user presses ENTER
            Console.ReadLine();

            // Colours the background cyan
            Console.BackgroundColor = ConsoleColor.Cyan;

            // Clears the console to apply the background colour to the whole screen
            Console.Clear();

            Console.WriteLine("My favourite food is pizza!");
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();

            // Resets the console colours to default
            Console.ResetColor();

            // To set a comment, use two forward slashes.

            // Makes a box with a yellow background
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("       ");
            Console.WriteLine("       ");
            Console.WriteLine("       ");

        }
    }
}
