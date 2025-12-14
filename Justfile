# Justfile for crab

DEFAULT_PROJECT := "src/Crab/Crab.csproj"

_default: help

@help:
    just --list

@build:
    dotnet build

@build-release:
    dotnet build -c Release

@run:
    dotnet run --project {{DEFAULT_PROJECT}}

@run-release:
    dotnet run --project {{DEFAULT_PROJECT}} -c Release

@watch:
    dotnet watch --project {{DEFAULT_PROJECT}}

@clean:
    dotnet clean

@restore:
    dotnet restore
