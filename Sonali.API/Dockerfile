# STEP 1: Build stage
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy solution file and restore dependencies
COPY *.sln ./
COPY Sonali.API/*.csproj Sonali.API/
COPY Sonali.API.Domain/*.csproj Sonali.API.Domain/
COPY Sonali.API.DomainService/*.csproj Sonali.API.DomainService/
COPY Sonali.API.Infrastructure.DAL/*.csproj Sonali.API.Infrastructure.DAL/
COPY Sonali.API.Infrastructure.Data/*.csproj Sonali.API.Infrastructure.Data/
COPY Sonali.API.Utilities/*.csproj Sonali.API.Utilities/
# (Skip Tests from docker)
RUN dotnet restore

# Copy all source and build
COPY . .
WORKDIR /src/Sonali.API
RUN dotnet publish -c Release -o /app/publish

# STEP 2: Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Sonali.API.dll"]
