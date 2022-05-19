namespace InMemory.Accumulators;

public sealed class Accumulator
{
    private int acc;
    private int hits;
    private static Accumulator? _instance = null;

    private Accumulator()
    {
        this.acc = 0;
        this.hits = 0;
    }

    public static Accumulator GetInstance()
    {
        if (_instance == null)
            _instance = new Accumulator();

        return _instance;
    }

    private void alter(int val)
    {
        this.hits++;
        this.acc += val;
    }

    public void Inc(int val)
    {
        this.alter(val);
    }

    public void Dec(int val)
    {
        this.alter(0 - val);
    }

    public AccumulatorStatus Get()
    {
        return new AccumulatorStatus(this.acc, this.hits);
    }
}
