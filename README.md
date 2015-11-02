# Bootstrap
A scaffolding setup to bootstrap a project to get up and running. 

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

