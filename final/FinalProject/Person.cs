public class Person
{
    private string _relation;
    private string _surname;
    private string _givenName;
    private int _birthYear;
    private string _birthCountry;
    private int _deathYear;
    private string _deathCountry;
    public Person(string relation, string surname, string givenName, int birthYear, string birthCountry, int deathYear, string deathCountry)
    {
        _relation = relation;
        _surname = surname;
        _givenName = givenName;
        _birthYear = birthYear;
        _birthCountry = birthCountry;
        _deathYear = deathYear;
        _deathCountry = deathCountry;
    }
    // This is created for the list:
    public string GetPersonString()
    {
        return $"{_surname}, {_givenName} - your {_relation} - Year of Birth: {_birthYear}, Born in: {_birthCountry}, Year of Death: {_deathYear}, Died in: {_deathCountry} ";
    }

}