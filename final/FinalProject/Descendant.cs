public class Descendant : Relative
{
    public Descendant(string surname, string givenName, string gender, string relation, int birthYear, string birthCountry) : base(surname, givenName, gender, relation, birthYear, birthCountry)
    {

    }
    public Descendant(string surname, string givenName, string gender, string relation, int birthYear, string birthCountry, int deathYear, string deathCountry, string spouseSurname, string spouseGivenName, int spouseBirthYear, string spouseBirthCountry, int numberofChildren) : base(surname, givenName, gender, relation, birthYear, birthCountry, deathYear, deathCountry, spouseSurname, spouseGivenName, spouseBirthYear, spouseBirthCountry, numberofChildren)
    {

    }
    public virtual string GetRelativeType()
    {
        return "";
    }
    public override void DisplayRelative()
    {
        
    }
}
