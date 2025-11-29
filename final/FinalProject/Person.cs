using System.Runtime.CompilerServices;

public class Person
{
    protected string _relation;
    protected string _surname;
    protected string _givenName;
    protected int _birthYear;
    protected string _birthCountry;
    protected int _deathYear;
    protected string _deathCountry;
    public Person(string relation, string surname, string giveName, int birthYear, string birthCountry, int deathYear, string deathCountry)
    {
        relation = _relation;
        surname = _surname;
        giveName = _givenName;
        birthYear = _birthYear;
        birthCountry = _birthCountry;
        deathYear = _deathYear;
        deathCountry = _deathCountry;
    }
    public string GetPersonString()
    {
        return $"{_surname}, {_givenName} - your {_relation} - Year of Birth: {_birthYear}, Born in: {_birthCountry}, Year of Death: {_deathYear}, Died in: {_deathCountry} ";
    }

}