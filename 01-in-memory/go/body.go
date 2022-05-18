package main

type AccReqBody struct {
	Action string `json:"action" binding:"required"`
	Value  int    `json:"value" binding:"required"`
}
