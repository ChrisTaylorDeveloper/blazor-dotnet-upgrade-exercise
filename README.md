# Blazor Todo WASM dotnet 7.0

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
