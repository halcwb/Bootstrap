# Bootstrap
A scaffolding setup to bootstrap a `.net` or any other project to get up and running. This setup is heavily influenced by [ProjectScafold](https://github.com/fsprojects/ProjectScaffold). It uses [Paket](https://github.com/fsprojects/Paket) to resolve dependencies and [FSharp.Formatting](https://github.com/tpetricek/Fsharp.Formatting) to automatically create documentation.


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


## Setup

* Download the zipped project and unzip in the root directory of your project. 
* Update the project specific settings in the `scripts/Settings.fsx` file.
* Update and add `fsx` docs to the `docs/content` folder.
* Update this `README.md` and the `RELEASE_NOTES.md` files.

Note that the included `.gitignore` file uses an 'opt-in' approach, i.e. all files are ignored unless specifically included are 'unignored' in the `.gitignore` file. This prevents accidental inclusion of files in the git repository.


## Building
The build can be started by running:

* `build.sh` on unix systems (tested on max os x)
* `build.cmd` on windows systems

Running `build.cmd` or `./build.sh` is the same as running the command with the `ALL` argument. To list all build targets use the `--listTargets` or `-lt` argument.

## Bootstrapping
The bootstrapping mechanism does the following:

1. Check if a paket.exe exists
2. Download the paket.exe if not
3. Use the paket.exe to install dependencies


## Testing
Testing will be run after the build. As specified by the testing target in the `build.fsx` script.

## Continuous integration
This setup assumes that the current branch is a development branch. There is a specific integration target that can be run by `./build.sh integrate` or `build.cmd integrate`:

1. First it checks whether all changes are commited, i.e. the current repos is clean.
2. Then the latest Appveyor (.net) and Travis (mono) builds are checked whether they passed.
3. Then the master branch is checked out and updated with the `remotes/origin/master` branch.
3. The current branch is merged with the master branch and pushed to GitHub.
4. Finally the current branch is checkout out to resume development.


## Documentation
Documentation is automatically generated using the `.fsx` files and the `.md` files in the `docs/content/` folder. How to create additional information is described [here](https//tpetricek.github.io/FSharp.Formatting).


## Publishing
TODO


## Deployment
Automated deployment to Heroku using a mono environment and Azure using a regular .net environment. 
TODO

