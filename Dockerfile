FROM mcr.microsoft.com/dotnet/sdk:5.0-buster-slim AS build-env
WORKDIR /app

# Set intermediate stage as build
LABEL stage=build

# Copy csproj and restore as distinct layers
COPY *.sln ./
COPY /src/VulnerableApp.WebApi/*.csproj ./src/VulnerableApp.WebApi/
COPY /src/VulnerableApp.Library.Contracts/*.csproj ./src/VulnerableApp.Library.Contracts/
COPY /src/VulnerableApp.Library.Impl/*.csproj ./src/VulnerableApp.Library.Impl/
COPY /src/VulnerableApp.Repository.Contracts/*.csproj ./src/VulnerableApp.Repository.Contracts/
COPY /src/VulnerableApp.Repository.Impl/*.csproj ./src/VulnerableApp.Repository.Impl/
COPY /src/VulnerableApp.Core.Extensions/*.csproj ./src/VulnerableApp.Core.Extensions/
COPY Packages.props ./ 

RUN dotnet restore "./src/VulnerableApp.WebApi/VulnerableApp.WebApi.csproj" -s "https://api.nuget.org/v3/index.json"

# Copy everything else and build
COPY . ./
RUN dotnet publish src/VulnerableApp.WebApi/*.csproj -c Release -o /app/publish

# Build runtime imagedock
FROM mcr.microsoft.com/dotnet/aspnet:5.0-buster-slim
WORKDIR /app
COPY --from=build-env /app/publish .
ENTRYPOINT ["dotnet", "VulnerableApp.WebApi.dll"]
