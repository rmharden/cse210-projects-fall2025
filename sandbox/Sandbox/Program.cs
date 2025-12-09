using System;

class Program
{
    static void Main(string[] args)
    {
        UsersInfo uf1 = new UsersInfo();
        uf1.GetUsersInfo();
    }
    public class UsersInfo
    {
        private string _usersName;
        private string _relation;

        public UsersInfo()
        {

        }
        public void GetUsersInfo()
        {
            Console.Write("\nWhat is your name? ");
            string _usersName = Console.ReadLine();

            Console.Write("\nWhat is your relation to this relative? (example: son, daughter, grandson, granddaugher...) ");
            string _relation = Console.ReadLine();
        }
    }
    public class BasicQuestions
    {
        public BasicQuestions()
        {
            Console.Write("\nWhat is your your relative's given name? ");
            string _givenName = Console.ReadLine();

            Console.Write("\nWhat is your your relative's surname name? ");
            string _surname = Console.ReadLine();

            Console.Write("\nWhat is the year your relative was born? ");
            int _yearBorn = int.Parse(Console.ReadLine());

            Console.Write("\nWhat is the country is where your relative was born? ");
            string _countryBorn = Console.ReadLine();
        }
    }
    public class AdvancedQuestions
    {
        public AdvancedQuestions()
        {

        }
        public string GetAdvancedQuestions()
        {
            Console.Write("\nWhat is the year your relative died? ");
            int _yearDied = int.Parse(Console.ReadLine());

            Console.Write("\nWhat is the country is where your relative was died? ");
            string _countryDeath = Console.ReadLine();

            Console.Write("\nWas your relative married? (yes or no) ");
            string _married = Console.ReadLine();

            Console.Write("\nWhat is your your relative spouses's given name? ");
            string _spouseGivenName = Console.ReadLine();

            Console.Write("\nWhat is your your relative's spouse's surname name? ");
            string _spouseSurname = Console.ReadLine();

            return 
        }
    }
    public class FamilyGroupSheet
    {
        public FamilyGroupSheet()
        {

        }
        public void DisplayFamilyGroupSheet()
        {
            Console.WriteLine($"Family Group Record");
            Console.WriteLine($"Prepared by {}");
            Console.WriteLine($"");
            Console.WriteLine($"");
            Console.WriteLine($"");
        }
    }
}