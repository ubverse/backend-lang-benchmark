using Microsoft.AspNetCore.Mvc;
using InMemory.Accumulators;

namespace InMemory.Controllers;

public class AccumulatorRequest
{
    public string action { get; set; }
    public int value { get; set; }
}

[ApiController]
public class InMemoryController : ControllerBase
{
    private Accumulator accumulator;

    public InMemoryController()
    {
        accumulator = Accumulator.GetInstance();
    }

    private int getValueQueryParam()
    {
        return Int32.Parse(HttpContext.Request.Query["value"]);
    }

    [HttpGet("/status")]
    public AccumulatorStatus GetAccumulatorStatus()
    {
        return accumulator.Get();
    }

    [HttpPost("/increment")]
    public void IncrementAccumulator()
    {
        accumulator.Inc(getValueQueryParam());
    }

    [HttpPost("/decrement")]
    public void DecrementAccumulator()
    {
        accumulator.Dec(getValueQueryParam());
    }

    [HttpPost("/accumulator")]
    public void AccumulateFromMessage([FromBody] AccumulatorRequest body)
    {
        if (body.action == "increment")
            accumulator.Inc(body.value);

        if (body.action == "decrement")
            accumulator.Dec(body.value);
    }
}
