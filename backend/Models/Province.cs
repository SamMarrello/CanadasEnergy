namespace backend.Models;

public class Province
{
    public int Id { get; set; }
    public int Name { get; set; }
    public Dictionary<GenerationBreakdown, double> Breakdown { get; set; }
}