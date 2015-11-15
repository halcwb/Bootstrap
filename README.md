# Bootstrap
A scaffolding setup to bootstrap a `.net` project to get up and running. This project is heavily influence by [ProjectScaffold](https://github.com/fsprojects/ProjectScaffold).

## Build Status

Mono | .NET
---- | ----
[![Mono CI Build Status](https://img.shields.io/travis/halcwb/Bootstrap/master.svg)](https://travis-ci.org/halcwb/Bootstrap) | [![.NET Build Status](https://img.shields.io/appveyor/ci/halcwb/Bootstrap/master.svg)](https://ci.appveyor.com/project/halcwb/Bootstrap)


## Principles

1. The master branch always builds on both mono and .net and contains the last good code
2. All tests in the master branch always pass
3. The master branch is merged with the develop branch only if build passes on the ci machines (Travis and Appveyor) and all tests pass
4. Builds are completely automated
5. Continuous Integration is completely automated
6. Documentation is completely automated
7. Publishing to nuget is completely automated
8. Deployment is completely automated

## Running bootstrap
Bootstrapping can be started by running:

* `build.sh` on unix systems (tested on max os x)
* `build.cmd` on windows systems

## Bootstrapping
Will do the following:

1. Use `.paket/paket.bootstrapper.exe` to fetch the latest `paket` release.
2. Install all project dependencies using `paket.dependencies` with versions as specified by the `paket.lock` file

## Building
Builds the project using the `build.fsx` file.

## Testing
Run the `test` targets in the `build.fsx` file.

## Continuous integration
This setup assumes that all development happens on the develop branch. There is a specific integration target that can be run by `./build.sh integrate` or `build.cmd integrate`:

1. First it checks whether all changes are commited, i.e. the current repos is clean.
2. Then the latest Appveyor (.net) and Travis (mono) builds are checked whether they passed.
3. Then the develop branch is merged with the master branch and the master branch is pushed to GitHub.
4. Finally the develop branch is checkout out to continue development

## Documentation
All documentation is automatically generated using the [FSharp.Formatting](https://github.com/tpetricek/FSharp.Formatting) project.

## Publishing
TODO

## Deployment
Automated deployment to Heroku using a mono environment and Azure using a regular .net envorinment. 
TODO

