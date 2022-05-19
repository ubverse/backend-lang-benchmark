package com.upsetbit.kotapi.inmemory

import org.springframework.boot.autoconfigure.SpringBootApplication
import org.springframework.boot.runApplication

@SpringBootApplication
class InmemoryApplication

fun main(args: Array<String>)
{
    runApplication<InmemoryApplication>(*args)
}
