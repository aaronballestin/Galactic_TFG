# Galactic_TFG

## Índice

## Diagrama BBDD


## Comandos utilizados para crear el proyecto

```plaintext
dotnet new sln -n GalacticApi

dotnet new classlib -n GalacticApi.Models -o Models 
dotnet sln add ./Models/GalacticApi.Models.csproj 
dotnet build ./Models/GalacticApi.Models.csproj

dotnet new classlib -n GalacticApi.Services -o Services 
dotnet sln add ./Services/GalacticApi.Services.csproj 
dotnet build ./Services/GalacticApi.Services.csproj

dotnet new classlib -n GalacticApi.Data -o Data 
dotnet sln add ./Data/GalacticApi.Data.csproj 
dotnet build ./Data/GalacticApi.Data.csproj

dotnet new webapi -n GalacticApi.Api -o Api 
dotnet sln add ./Api/GalacticApi.Api.csproj 
dotnet build ./Api/GalacticApi.Api.csproj

dotnet add ./Services/GalacticApi.Services.csproj reference ./Models/GalacticApi.Models.csproj

dotnet add ./Api/GalacticApi.Api.csproj reference ./Services/GalacticApi.Services.csproj

dotnet add ./Services/GalacticApi.Services.csproj reference ./Data/GalacticApi.Data.csproj

dotnet add ./Data/GalacticApi.Data.csproj reference ./Models/GalacticApi.Models.csproj

```


## Comandos utilizados para dockerizar
```plaintext
docker-compose up --build --force-recreate -d

docker-compose down -v

dotnet ef migrations remove  -p ./Data/GalacticApi.Data.csproj -s ./Api/GalacticApi.Api.csproj

dotnet tool install --global dotnet-ef --version 6.*

dotnet ef migrations add BBDD -p ./Data/GalacticApi.Data.csproj -s ./Api/GalacticApi.Api.csproj

dotnet ef database update  -p ./Data/GalacticApi.Data.csproj -s ./Api/GalacticApi.Api.csproj
```