package com.upsetbit.kotapi.inmemory

import org.springframework.web.bind.annotation.GetMapping
import org.springframework.web.bind.annotation.PostMapping
import org.springframework.web.bind.annotation.RequestParam
import org.springframework.web.bind.annotation.RequestBody
import org.springframework.web.bind.annotation.RestController

import com.upsetbit.kotapi.inmemory.accumulator.accumulator
import com.upsetbit.kotapi.inmemory.accumulator.AccumulatorStatus

@RestController
class InMemoryController
{
    @GetMapping("/status")
    fun getAccumulatorStatus() = accumulator.get()

    @PostMapping("/increment")
    fun incrementAccumulator(@RequestParam value: Int) = accumulator.inc(value)

    @PostMapping("/decrement")
    fun decrementAccumulator(@RequestParam value: Int) = accumulator.dec(value)

    @PostMapping("/accumulator")
    fun accumulateFromMessage(@RequestBody body: AccumulatorRequest)
    {
        if (body.action == "increment")
            accumulator.inc(body.value)

        if (body.action == "decrement")
            accumulator.dec(body.value)
    }
}
