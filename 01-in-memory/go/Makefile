.DEFAULT_GOAL := run

ARTIFACT = server

build:
	@go build -tags "nomsgpack go_json" -o $(ARTIFACT)

run: build
run:
	./$(ARTIFACT)
