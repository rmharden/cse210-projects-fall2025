public class EthnicityCalculator
{
    private List<string> _countries = new List<string>();
    public EthnicityCalculator()
    {

    }
    public void GetEthnicityEstimate()
    {
        foreach (string country in _countries)
        {
            bool found = false;
            foreach (int c in counts)
            {
                if (c.country == country)
                {
                    c.Count++;
                    found = true;
                }
            }
        }
    }
}