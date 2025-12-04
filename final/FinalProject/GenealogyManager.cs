using System.Globalization;
public class GenealogyManager
{
    private List<Relative> _realitives;
    public GenealogyManager()
    {
        _realitives = new List<Relative>();
        //menu
        string userInput = "";

        // This works so far.
        while (userInput != "6")
        {
            Console.WriteLine("Please select one of the following choices:");

            Console.WriteLine("1. Enter a Relative");
            Console.WriteLine("2. Display Relatives");
            Console.WriteLine("3. Load File");
            Console.WriteLine("4. Save File");
            Console.WriteLine("5. Ethnicity Estimate");
            Console.WriteLine("6. Quit");

            Console.Write("What would you like to do? ");
            userInput = Console.ReadLine();
            if (userInput == "1")
            {

            }
            else if (userInput == "2")
            {

            }
            else if (userInput == "3")
            {

            }
            else if (userInput == "4")
            {

            }
            else if (userInput == "5")
            {
                EthnicityCalculator e1 = new EthnicityCalculator();

                Console.Write("What is the name of the country? ");
                string country = Console.ReadLine();
                country = country.Trim().ToLower();

                while (country != "quit")
                {
                    TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
                    e1.AddCountry(ti.ToTitleCase(country));

                    Console.Write("What is the name of the country? ");
                    country = Console.ReadLine();
                    country = country.Trim().ToLower();
                }
                e1.GetEthnicityEstimate();
            }
            else if (userInput == "6")
            {
                Console.WriteLine("Thank you for using the Genealogy Program!\n");
            }
            else
            {
                Console.WriteLine("Invalid number.");
            }
        }
    }
    public void AddRelative()
    {
        Console.Write("\n1. Ancestor");
        Console.Write("\n2. Decendant");
        Console.Write("\n3. Other Relative");
        Console.WriteLine("Please select an option (1, 2, or 3): ");
        string option = Console.ReadLine();

        if (option == "1")
        {
            // This will ask the questions
            AskUserPreference();
            // I need to add the parameters for ancestor here:
            Ancestor a1 = new Ancestor();
        }
        else if (option == "2")
        {
            AskUserPreference();

        }
        else if (option == "3")
        {
            AskUserPreference();

        }
        else
        {
            Console.WriteLine("Invalid number.");
        }
    }
    public void AskUserPreference()
    {
        Console.WriteLine("1. Basic Vital Questions.");
        Console.WriteLine("2. Advanced Vital Questions");
        Console.Write("\nPlese make a selction: ");
        string selection = Console.ReadLine();
        if (selection == "1")
        {
            BasicQuestions b1 = new BasicQuestions();
            b1.AskQuestions();
        }
        else if (selection == "2")
        {
            BasicQuestions bq1 = new BasicQuestions();
            bq1.AskQuestions();
            AdvancedQuestions aq1 = new AdvancedQuestions();
            bq1.AskQuestions();
        }
        else
        {
            Console.WriteLine("Invalid number.");
        }
    }
}
