# ----------------------------
# STAGE 1: Restore & Build
# ----------------------------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy csproj files for caching
COPY Sonali.API/*.csproj Sonali.API/
COPY Sonali.API.Domain/*.csproj Sonali.API.Domain/
COPY Sonali.API.DomainService/*.csproj Sonali.API.DomainService/
COPY Sonali.API.Infrastructure.DAL/*.csproj Sonali.API.Infrastructure.DAL/
COPY Sonali.API.Infrastructure.Data/*.csproj Sonali.API.Infrastructure.Data/
COPY Sonali.API.Utilities/*.csproj Sonali.API.Utilities/

RUN dotnet restore Sonali.API/Sonali.API.csproj

# Copy all source code
COPY . .

RUN dotnet build Sonali.API/Sonali.API.csproj -c Release -o /app/build

# ----------------------------
# STAGE 2: Publish
# ----------------------------
FROM build AS publish
RUN dotnet publish Sonali.API/Sonali.API.csproj -c Release -o /app/publish /p:UseAppHost=false

# ----------------------------
# STAGE 3: Runtime
# ----------------------------
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

COPY --from=publish /app/publish .

EXPOSE 80
EXPOSE 443

ENTRYPOINT ["dotnet", "Sonali.API.dll"]
