public class CountCountries
{
    private string _country;
    private int _count;
    public CountCountries(string country, int count)
    {
        _country = country;
        _count = count;
    }
    public string GetCountry()
    {
        return _country;
    }
    public void SetCountry(string country)
    {
        _country = country;
    }
    public int GetCount()
    {
        return _count;
    }
    public void SetCount(int count)
    {
        _count = count;
    }
    public void CountryCounter()
    {
        _count++;
    }
}