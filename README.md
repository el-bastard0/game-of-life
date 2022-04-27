# game-of-life

[![Conventional Commits](https://img.shields.io/badge/Conventional%20Commits-1.0.0-yellow.svg)](https://conventionalcommits.org)
[![Semantic release](https://github.com/el-bastard0/game-of-life/actions/workflows/semantic-release.yml/badge.svg)](https://github.com/el-bastard0/game-of-life/actions/workflows/semantic-release.yml)

[![Issue Tracker](https://github.com/el-bastard0/game-of-life/actions/workflows/issue-tracker.yml/badge.svg)](https://github.com/el-bastard0/game-of-life/actions/workflows/issue-tracker.yml)

## Prerequisites

1. Download and install the matching [.Net 6 runtime](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) for your system.

2. Download the [latest executable](https://github.com/el-bastard0/game-of-life/releases) for your system.

## Usage

Open the commandline of your choice and type

### Linux

```sh
dotnet <path>/<to>/<executable>/GameOfLife.<your os>.dll [-Options]
```

### Windows

```sh
<path>/<to>/<executable>/GameOfLife.<your os>.exe [-Options]
```

### Options

Type `dotnet <path>/<to>/<executable>/GameOfLife.<your os>.dll --help` to open help screen.

```sh

  -w, --width         (Default: 100) Game field width

  -h, --height        (Default: 40) Game field height

  -p, --population    (Default: Width * Height / 2) Initial population

  -r, --refresh       (Default: 100) Refresh cycle in ms

  --help              Display this help screen.

  --version           Display version information.
```

## License

[![License: GPL v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](LICENSE)
