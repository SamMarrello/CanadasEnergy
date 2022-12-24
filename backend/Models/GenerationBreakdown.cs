namespace backend.Models;

public enum GenerationBreakdown
{
    Coal,
    Oil,
    Nuclear,
    Wind,
    Biomass,
    Solar,
    Hydro,
    Geothermal
}

public struct Container
{
    public double Price { get; set; }
    public double Percent { get; set; }
}