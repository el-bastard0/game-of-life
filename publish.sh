#!/bin/bash

project='./src/app/ElBastard0.GameOfLife.csproj'

dotnet restore $project
dotnet build --configuration Release --no-restore -t:PublishAllRids $project