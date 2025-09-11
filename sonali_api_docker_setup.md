# Sonali.API Docker Setup

## Project Structure

```
/YourSolutionRoot
│── .env
│── Dockerfile
│── docker-compose.yml
│── docker-compose.override.yml
│── docker-compose.prod.yml
│── Sonali.API/
│── Sonali.API.Domain/
│── Sonali.API.DomainService/
│── Sonali.API.Infrastructure.DAL/
│── Sonali.API.Infrastructure.Data/
│── Sonali.API.Utilities/
│── Sonali.API.Tests/
│── Sonali.sln
```

---

## .env File

```env
# Environment
ASPNETCORE_ENVIRONMENT=Development

# Development SQL Server (local)
DEV_DB_CONN=Server=host.docker.internal,1433;Database=LogicalTestDB;User Id=sa;Password=Sli@2025#;TrustServerCertificate=True

# Production SQL Server (remote)
PROD_DB_CONN=Server=172.17.20.104;Database=LogicalTestDB;User Id=seTutul;Password=yK829>ug;TrustServerCertificate=True

# SQL Server container SA password
MSSQL_SA_PASSWORD=Your_strong_password123
```

---

## Dockerfile

```dockerfile
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy csproj files for restore
COPY Sonali.API/*.csproj Sonali.API/
COPY Sonali.API.Domain/*.csproj Sonali.API.Domain/
COPY Sonali.API.DomainService/*.csproj Sonali.API.DomainService/
COPY Sonali.API.Infrastructure.DAL/*.csproj Sonali.API.Infrastructure.DAL/
COPY Sonali.API.Infrastructure.Data/*.csproj Sonali.API.Infrastructure.Data/
COPY Sonali.API.Utilities/*.csproj Sonali.API.Utilities/

RUN dotnet restore Sonali.API/Sonali.API.csproj
COPY . .
RUN dotnet build Sonali.API/Sonali.API.csproj -c Release -o /app/build

FROM build AS publish
RUN dotnet publish Sonali.API/Sonali.API.csproj -c Release -o /app/publish /p:UseAppHost=false

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app
COPY --from=publish /app/publish .

EXPOSE 9090
ENTRYPOINT ["dotnet", "Sonali.API.dll"]
```

---

## docker-compose.yml

```yaml
version: "3.9"

services:
  sonali-api:
    image: sonali-api:latest
    build:
      context: .
      dockerfile: Dockerfile
    container_name: sonali-api
    ports:
      - "9090:9090"
    environment:
      - ASPNETCORE_URLS=http://+:9090
    depends_on:
      - mssql

  mssql:
    image: mcr.microsoft.com/mssql/server:2022-latest
    container_name: sonali-sql
    ports:
      - "1433:1433"
    environment:
      - ACCEPT_EULA=Y
      - MSSQL_SA_PASSWORD=${MSSQL_SA_PASSWORD}
    volumes:
      - mssql_data:/var/opt/mssql

volumes:
  mssql_data:
```

---

## docker-compose.override.yml (Development)

```yaml
services:
  sonali-api:
    environment:
      - ASPNETCORE_ENVIRONMENT=${ASPNETCORE_ENVIRONMENT}
      - ConnectionStrings__MsSqlConnectionString=${DEV_DB_CONN}
```

---

## docker-compose.prod.yml (Production)

```yaml
services:
  sonali-api:
    environment:
      - ASPNETCORE_ENVIRONMENT=Production
      - ConnectionStrings__MsSqlConnectionString=${PROD_DB_CONN}
```

---

## Commands

### Development

```bash
docker compose --env-file .env -f docker-compose.yml -f docker-compose.override.yml up --build
```

### Production

```bash
docker compose --env-file .env -f docker-compose.yml -f docker-compose.prod.yml up --build -d
```

---

## API Access

- **API URL:** `http://localhost:9090`
- **Swagger:** `http://localhost:9090/swagger`
- **SignalR Hub:** `http://localhost:9090/chathub`
- **SQL Server:** `localhost,1433` (use `DEV_DB_CONN` or `PROD_DB_CONN`)

---

## Notes

- Ensure `.env` passwords are strong.
- API container listens on port 9090; adjust Dockerfile and Compose ports if needed.
- Volume `mssql_data` persists SQL Server database data.

