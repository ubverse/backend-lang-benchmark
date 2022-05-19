.DEFAULT_GOAL := run

tag = latest
runtime = linux-x64
ARTIFACT = bin/Release/net6.0/$(runtime)/publish/inmemory

HERE  = $(shell pwd)
LANG  = $(shell basename $(HERE))
GROUP = $(shell basename $(shell dirname $(HERE)))
ZIP   = ./$(GROUP)-$(LANG)-sample-$(tag).zip

run:
	@dotnet run --urls "http://localhost:8080"

build:
	@dotnet publish \
		--configuration Release \
		--runtime $(runtime) \
		--self-contained true \
		-p:PublishSingleFile=true \
		-p:PublishReadyToRun=true

package: build
package:
	@zip -j $(ZIP) $(ARTIFACT)
