package com.upsetbit.kotapi.inmemory.accumulator

object accumulator
{
    var acc: Int = 0
    var hits: Int = 0

    private fun alter(value: Int)
    {
        this.hits++
        this.acc += value
    }

    fun inc(value: Int) = this.alter(value)

    fun dec(value: Int) = this.alter(0 - value)

    fun get() = AccumulatorStatus(this.acc, this.hits)
}
