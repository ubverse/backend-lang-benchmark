using Microsoft.AspNetCore.Mvc;
using InMemory.Accumulators;

namespace InMemory.Controllers;

[ApiController]
public class InMemoryController : ControllerBase
{
    private Accumulator accumulator;

    public InMemoryController()
    {
        this.accumulator = Accumulator.GetInstance();
    }

    [HttpGet("/status")]
    public AccumulatorStatus GetAccumulatorStatus()
    {
        return this.accumulator.Get();
    }
}
