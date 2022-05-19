.DEFAULT_GOAL := run

tag = latest
ARTIFACT = build/libs/inmemory-0.0.1-SNAPSHOT.jar

HERE  = $(shell pwd)
LANG  = $(shell basename $(HERE))
GROUP = $(shell basename $(shell dirname $(HERE)))
ZIP   = ./$(GROUP)-$(LANG)-sample-$(tag).zip


.PHONY: build
build:
	@gradle bootJar

run: build
run:
	@java -jar $(ARTIFACT)

package: build
package:
	@zip -j $(ZIP) $(ARTIFACT)
