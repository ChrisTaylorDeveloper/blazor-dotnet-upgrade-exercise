# Blazor .NET upgrade exercise

See <https://learn.microsoft.com/en-us/aspnet/core/blazor/tutorials/build-a-blazor-app?view=aspnetcore-7.0>

For serverblazor

```
docker run -it -p 5023:5023 --volume $(pwd):/source --workdir /source mcr.microsoft.com/dotnet/sdk:7.0
```

For wasmblazor

```
docker run -it -p 5054:5054 --volume $(pwd):/source --workdir /source mcr.microsoft.com/dotnet/sdk:7.0
```

Run and watch

```
dotnet run watch
```

## Migrate from ASP.NET Core in .NET 7 to .NET 8

Main article
<https://learn.microsoft.com/en-us/aspnet/core/migration/70-80?view=aspnetcore-8.0&tabs=visual-studio>

### Convert a Blazor Server app into a Blazor Web App

<https://learn.microsoft.com/en-us/aspnet/core/migration/70-80?view=aspnetcore-8.0&tabs=visual-studio#convert-a-blazor-server-app-into-a-blazor-web-app>

Seemingly, "Blazor Server apps are supported in .NET 8 without any code changes".  Therefore, try serverblazor in .NET 8.

```
docker run -it -p 5023:5023 --volume $(pwd):/source --workdir /source mcr.microsoft.com/dotnet/sdk:8.0
```

### Update a Blazor WebAssembly app

<https://learn.microsoft.com/en-us/aspnet/core/migration/70-80?view=aspnetcore-8.0&tabs=visual-studio#update-a-blazor-webassembly-app>
