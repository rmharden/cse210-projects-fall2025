using System.Reflection.Metadata;

public class ListingActivity
{
    private int _count;
    private List<string> _prompts;
    public ListingActivity()
    {

    }
    public void Run()
    {
        Console.Write("Welcome to the Listing Activity.\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n\nHow long in seconds, would you like your session? ");

        Console.WriteLine("List as many responses you can to the following prompt:");

        GetRandomPrompt();

        Console.WriteLine("You may begin in: (this is where there is a countdown in numbers.)");
        Console.Write("> ");
        GetListFromUser();
    }
    public void GetRandomPrompt()
    {

    }
    public List<String> GetListFromUser()
    {
        string usersInput = Console.ReadLine();
        List<string> usersList = new List<string>();
        Console.WriteLine("");
        usersList.Add(usersInput);
        int usersInputCount = usersList.Count();
        Console.WriteLine($"You listed {usersInputCount} items!");
        return usersList;
    }
}