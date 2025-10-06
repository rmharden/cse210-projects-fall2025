using System;

class Program
{
    static void Main(string[] args)
    {
        Entry anEntry = new Entry();

        Console.WriteLine("Welcome to the Journal Program!");
        string userInput = "";

        // This works so far.
        while (userInput != "5")
        {
            Console.WriteLine("Please select one of the following choices:");

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            userInput = Console.ReadLine();
            if (userInput == "1")
            {
                // Menu Test:
                // Console.WriteLine("You would like to Write.");

                // This works:
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                // This works:
                // I think I need this outside of the loop, though, because I have other menu options that need to use the Entry instance.
                // Entry anEntry = new Entry();
               
                anEntry._date = dateText;

                // This works:
                PropmptGenerator aPrompt = new PropmptGenerator();
                Console.WriteLine(aPrompt.GetRandomPrompt());

                // This works:
                // This is is here to test the code:
                anEntry.Display();

            }
            else if (userInput == "2")
            {
                Console.WriteLine("You would like to Display.");
            }
            else if (userInput == "3")
            {
                Console.WriteLine("You would like to Load.");
            }
            else if (userInput == "4")
            {
                Console.WriteLine("You would like to Save.");
            }
            else if (userInput == "5")
            {
                Console.WriteLine("Thank you for using the Journal Program.");
            }
            else
            {
                Console.WriteLine("Invalid number.");
            }
        }
    }
}


// https://video.byui.edu/media/t/1_vmeovorz
// This video talks about setting up the "stubs" for each class.