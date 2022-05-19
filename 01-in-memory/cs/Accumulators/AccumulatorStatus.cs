namespace InMemory.Accumulators;

public class AccumulatorStatus
{
    public int acc { get; }
    public int hits { get; }

    public AccumulatorStatus(int acc, int hits)
    {
        this.acc = acc;
        this.hits = hits;
    }
}
