# Blazor .NET upgrade exercise

Also see README in master branch.

## Getting started

Create a Docker dev environment for project in folder webblazor

```
docker run -it --rm -p 5133:5133 --volume $(pwd):/source --workdir /source mcr.microsoft.com/dotnet/sdk:8.0
```

Look for running app at <http://localhost:5133>
