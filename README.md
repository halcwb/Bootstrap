# Bootstrap
A scaffolding setup to bootstrap a `.net` project to get up and running. 

## Build Status

Mono | .NET
---- | ----
[![Mono CI Build Status](https://img.shields.io/travis/halcwb/Bootstrap/master.svg)](https://travis-ci.org/halcwb/Bootstrap) | [![.NET Build Status](https://img.shields.io/appveyor/ci/halcwb/Bootstrap/master.svg)](https://ci.appveyor.com/project/halcwb/Bootstrap)


## Running bootstrap
Bootstrapping can be started by running:

* `build.sh` on unix systems (tested on max os x)
* `build.cmd` on windows systems

## Bootstrapping
The bootstrap.fsx does the following:

1. Check if a paket.exe exists
2. Download the paket.exe if not
3. Use the paket.exe to install dependencies

## Building
TODO

## Testing
TODO

## Continuous integration
This setup assumes that all development happens on the develop branch. There is a specific integration target that can be run by `./integrate.sh` or `integrate.cmd`:

1. First it checks whether all changes are commited, i.e. the current repos is clean.
2. Then the latest Appveyor (.net) and Travis (mono) builds are checked whether they passed.
3. Then the develop branch is merged with the master branch and pushed to GitHub.

## Deployment
Automated deployment to Heroku using a mono environment and Azure using a regular .net envorinment. 
TODO

