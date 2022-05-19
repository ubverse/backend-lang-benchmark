package com.upsetbit.kotapi.inmemory

import org.springframework.boot.autoconfigure.SpringBootApplication
import org.springframework.boot.runApplication

@SpringBootApplication
class InMemoryApplication

fun main(args: Array<String>)
{
    runApplication<InMemoryApplication>(*args)
}
