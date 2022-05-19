namespace InMemory.Accumulators;

public sealed class Accumulator
{
    private int acc;
    private int hits;
    private static Accumulator? _instance = null;

    private Accumulator()
    {
        acc = 0;
        hits = 0;
    }

    public static Accumulator GetInstance()
    {
        if (_instance == null)
            _instance = new Accumulator();

        return _instance;
    }

    private void alter(int val)
    {
        hits++;
        acc += val;
    }

    public void Inc(int val)
    {
        alter(val);
    }

    public void Dec(int val)
    {
        alter(0 - val);
    }

    public AccumulatorStatus Get()
    {
        return new AccumulatorStatus(acc, hits);
    }
}
