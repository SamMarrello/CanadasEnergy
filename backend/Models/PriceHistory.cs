namespace backend.Models;

public class PriceHistory
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public Dictionary<GenerationBreakdown, Container> PriceInfo { get; set; }
}