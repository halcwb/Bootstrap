# Bootstrap
A scaffolding setup to bootstrap a `.net` project to get up and running. 

## Build Status

Mono | .NET
---- | ----
[![Mono CI Build Status](https://img.shields.io/travis/halcwb/Bootstrap/master.svg)](https://travis-ci.org/halcwb/Bootstrap) | [![.NET Build Status](https://img.shields.io/appveyor/ci/halcwb/Bootstrap/master.svg)](https://ci.appveyor.com/project/halcwb/Bootstrap)


## Principles

1. The master branch always builds on both mono and .net
2. All tests in the master branch always pass
3. The master branch is only merged in from the develop branch, after the above is ensured, i.e. the develop branch builds and all tests pass
4. Build is completely automated
5. Continuous Integration is completely automated
6. Documentation is completely automated
7. Publishing to nuget is completely automated
8. Deployment is completely automated

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
4. Finally the develop branch is checkout out to continue development

## Documentation
TODO

## Publishing
TODO

## Deployment
Automated deployment to Heroku using a mono environment and Azure using a regular .net envorinment. 
TODO

