public abstract class Relative
{
    protected string _surname;
    protected string _givenName;
    protected string _gender;
    protected string _relation;
    protected int _birthYear;
    protected string _birthCountry;
    protected int _deathYear;
    protected string _deathCountry;
    protected string _spouseSurname;
    protected string _spouseGivenName;
    protected int _spouseBirthYear;
    protected string _spouseBirthCountry;
    protected int _numberOfChildren;
    public Relative(string surname, string givenName, string gender, string relation, int birthYear, string birthCountry)
    {
        _surname = surname;
        _givenName = givenName;
        _gender = gender;
        _relation = relation;
        _birthYear = birthYear;
        _birthCountry = birthCountry;
    }
    public Relative(string surname, string givenName, string gender, string relation, int birthYear, string birthCountry, int deathYear, string deathCountry, string spouseSurname, string spouseGivenName, int spouseBirthYear, string spouseBirthCountry, int numberofChildren)
    {
        _surname = surname;
        _givenName = givenName;
        _gender = gender;
        _relation = relation;
        _birthYear = birthYear;
        _birthCountry = birthCountry;
        _deathYear = deathYear;
        _deathCountry = deathCountry;
        _spouseSurname = spouseSurname;
        _spouseGivenName = spouseGivenName;
        _spouseBirthYear = spouseBirthYear;
        _spouseBirthCountry = spouseBirthCountry;
        _numberOfChildren = numberofChildren;
    }
    public virtual string GetRelativeType()
    {
        return "";
    }
    public abstract void DisplayRelative();
}
