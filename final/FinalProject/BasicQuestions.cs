public class BasicQuestions
{
    private List<Relative> _basicRelatives;
    private List<Relative> _advancedRelatives;
    private List<string> _countries;

    private string _surname;
    private string _givenName;
    private string _gender;
    private string _relation;
    private int _birthYear;
    private string _birthCountry;
    public BasicQuestions()
    {

    }
    public void AskQuestions()
    {
        Console.Write("\nWhat is the surname of this relative? ");
        _surname = Console.ReadLine();

        Console.Write("\nWhat is the given name of this relative? ");
        _givenName = Console.ReadLine();

        Console.Write("\nWhat is the gender of this relative? (male or female) ");
        _gender = Console.ReadLine();

        Console.Write("\nWhat is your relation to this relative?\n(For example: mother, father, grandmother, grandfather, etc)? ");
        _relation = Console.ReadLine();

        Console.Write("\nWhat is the birth year of this relative? ");
        _birthYear = int.Parse(Console.ReadLine());

        Console.Write("\nWhat is the birth country of this relative? ");
        _birthCountry = Console.ReadLine();
    }
}