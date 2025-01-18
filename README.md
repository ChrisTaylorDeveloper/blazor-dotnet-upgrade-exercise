# Blazor .NET upgrade exercise

This article followed initially, to create the apps
<https://learn.microsoft.com/en-us/aspnet/core/blazor/tutorials/build-a-blazor-app?view=aspnetcore-7.0>

## .NET dev environments in Docker

Remember to publish container port to host

```
docker run -it --rm -p <change-me>:<change-me> --volume $(pwd):/source --workdir /source mcr.microsoft.com/dotnet/sdk:7.0
```

```
docker run -it --rm -p <change-me>:<change-me> --volume $(pwd):/source --workdir /source mcr.microsoft.com/dotnet/sdk:8.0
```

## Run the apps

Run and watch the apps from inside Docker container(s)

```

dotnet run watch

```

## Migrate from ASP.NET Core in .NET 7 to .NET 8

Main article
<https://learn.microsoft.com/en-us/aspnet/core/migration/70-80?view=aspnetcore-8.0&tabs=visual-studio>

### Convert a Blazor Server app into a Blazor Web App

Git branch: 7-Server-App-to-8-Server-App
<https://learn.microsoft.com/en-us/aspnet/core/migration/70-80?view=aspnetcore-8.0&tabs=visual-studio#convert-a-blazor-server-app-into-a-blazor-web-app>

### Update a Blazor WebAssembly app

Git branch: 7-Wasm-App-to-8-Wasm-App
<https://learn.microsoft.com/en-us/aspnet/core/migration/70-80?view=aspnetcore-8.0&tabs=visual-studio#update-a-blazor-webassembly-app>
