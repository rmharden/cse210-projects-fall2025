/*
Rebekah Harden
CSE 210: Programming with Classes
Brother Randall Booth
October 6, 2025
*/


using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator aPrompt = new PromptGenerator();
        Journal aJournal = new Journal();

        // Changing this to a list:
        // Entry anEntry = new Entry();
        List<Entry> _entries = new List<Entry>();

        Console.WriteLine("\nWelcome to the Journal Program!");
        string userInput = "";

        // This works so far.
        while (userInput != "6")
        {
            Console.WriteLine("Please select one of the following choices:");

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Be Inspired");
            Console.WriteLine("6. Quit");

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
                Entry anEntry = new Entry();
                anEntry._date = dateText;

                // This works:
                // Moving this outside of the loop:
                // PromptGenerator aPrompt = new PromptGenerator();

                // Console.WriteLine(aPrompt.GetRandomPrompt());

                anEntry._promptText = aPrompt.GetRandomPrompt();
                // This makes a whole new prompt and does not display the same one that was saved as anEntry propmt.
                // Console.WriteLine(aPrompt.GetRandomPrompt());
                Console.WriteLine(anEntry._promptText);

                Console.Write("> ");
                anEntry._entryText = Console.ReadLine();

                // This works:
                // This is is here to test the code:
                // anEntry.Display();
                // Console.WriteLine("");

                aJournal.AddEntry(anEntry);


                // This doesn't work:
                // foreach (Entry entry in _entries)
                // {
                //     Console.WriteLine(entry);
                // }

                // Test:
                // moving this to the Display menu option... but I'm supposed to read from a file for that, right???
                // aJournal.DisplayAll();

            }
            else if (userInput == "2")
            {
                // Test:
                // Console.WriteLine("You would like to Display.");

                // This works. - But, I think I am supposed to have this read from a file - is that right???
                aJournal.DisplayAll();
            }
            else if (userInput == "3")
            {
                // Console.WriteLine("You would like to Load.");

                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();

                aJournal.LoadFromFile(filename);
            }
            else if (userInput == "4")
            {
                // Test:
                // Console.WriteLine("You would like to Save.");

                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();

                aJournal.SaveToFile(filename);
            }
            else if (userInput == "5")
            {
                // This is part of the "Shows Creativity" requirments: 
                Console.WriteLine("\nDescriptive writing can improve our journal entries. \nBy including descriptions of the the fives senses, our experiences become more than just statements in our journals. \nAs you read the prompt, think about what you can write in your entry that includes this sense. \nIf you don't want to use this sense in your journal entry, that's alright. You can skip it or move on to a different part of your journal.\nPress any key to continue.");

                Console.ReadKey();

                Console.Clear();
                FiveSenses aSense = new FiveSenses();
                Console.WriteLine($"\n{aSense.GetRandomSense()}\n");
            }
            else if (userInput == "6")
            {
                Console.WriteLine("Thank you for using the Journal Program!\n");
            }
            else
            {
                Console.WriteLine("Invalid number.");
            }
        }
    }
}

/* 
Showing creativity:
I created another menu option where the user can choose to be given a prompt where they will be aksed about one of the five senses. They can use that inspiration in their journal entry writing or pick another one.
Choosing option 5 gives a description of how to use the random sense, asks the user to press a key to continue, and then it calls the FiveSenses class where it randomly chooses one of the senses to display to the user.
The user is brought back to the main menu where they can choose any of the options provided.
*/


// https://video.byui.edu/media/t/1_vmeovorz
// This video talks about setting up the "stubs" for each class.