namespace InMemory.Accumulators;

public class AccumulatorStatus
{
    public int acc { get; }
    public int hits { get; }

    public AccumulatorStatus(int a, int h)
    {
        acc = a;
        hits = h;
    }
}
