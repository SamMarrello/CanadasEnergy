using NodaTime;

namespace backend.Models;

public class EnergyBase
{
    public ulong Id { get; set; }
    public Instant Date { get; set; }
    public Province Province { get; set; }
}

public class Generation : EnergyBase
{
    public double Oil;
    public double Nuclear;
    public double Wind;
    public double Biomass;
    public double Solar;
    public double Hydro;
    public double Geothermal;
    public double Coal;
}

public class GenerationDictionary : EnergyBase
{
    private Dictionary<EnergyProductionMethod, double> generation = new Dictionary<EnergyProductionMethod, double>();

    public void SetGeneration(EnergyProductionMethod method, double value)
    {
        generation[method] = value;
    }

    public double GetGeneration(EnergyProductionMethod method)
    {
        if (generation.ContainsKey(method))
        {
            return generation[method];
        }
        else
        {
            return 0;
        }
    }
}

class GenerationArray : EnergyBase
{
    public double[] generation = new double[(int)EnergyProductionMethod.Max];
}

