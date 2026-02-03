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
            
            // Does not add move the cursor to the next line

            Console.Write("Computers");
            Console.WriteLine(" Rule!");
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.WriteLine("My favourite food is pizza!");
            Console.WriteLine("Press ENTER to continue...");  
            Console.ReadLine();
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
