#!/bin/bash

project='./src/app/ElBastard0.GameOfLife.csproj'

dotnet restore $project
dotnet msbuild -t:PublishAllRids $project