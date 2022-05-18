.DEFAULT_GOAL := run

tag = latest
ARTIFACT = node_modules Makefile index.js accumulator.js

HERE  = $(shell pwd)
LANG  = $(shell basename $(HERE))
GROUP = $(shell basename $(shell dirname $(HERE)))
ZIP   = ./$(GROUP)-$(LANG)-sample-$(tag).zip


install:
	@npm install

run: install
run:
	@npm start

package: install
package:
	@zip -r $(ZIP) $(ARTIFACT)
