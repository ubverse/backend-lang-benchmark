package main

import (
	"github.com/gin-gonic/gin"
	"github.com/ubverse/backend-lang-benchmark/01-in-memory/go/accumulator"
	"strconv"
)

func getQueryValue(c *gin.Context) int {
	fallback := 1

	value := c.DefaultQuery("value", "")
	if value == "" {
		return fallback
	}

	i, err := strconv.Atoi(value)
	if err != nil {
		return fallback
	}

	return i
}

func main() {
	// gin.SetMode(gin.ReleaseMode)

	router := gin.Default()
	acc := accumulator.New()

	router.GET("/status", func(c *gin.Context) {
		hits, accv := acc.Get()

		c.JSON(200, gin.H{
			"acc":  accv,
			"hits": hits,
		})
	})

	router.POST("/increment", func(c *gin.Context) {
		value := getQueryValue(c)
		acc.Inc(value)

		c.Status(200)
	})

	router.POST("/decrement", func(c *gin.Context) {
		value := getQueryValue(c)
		acc.Dec(value)

		c.Status(200)
	})

	router.POST("/accumulator", func(c *gin.Context) {
		body := AccReqBody{}
		if err := c.ShouldBind(&body); err != nil {
			c.Status(400)
			return
		}

		switch body.Action {
		case "increment":
			acc.Inc(body.Value)
			break

		case "decrement":
			acc.Dec(body.Value)
			break
		}

		c.Status(200)
	})

	router.Run(":8080")
}
