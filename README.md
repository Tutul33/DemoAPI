# Sonali.API – ASP.NET Core 8 Web API (Clean Architecture)

## 📌 Overview

**Sonali.API** is an ASP.NET Core 8 Web API project following **Clean Architecture** principles.\
It separates concerns into distinct layers for maintainability, scalability, and testability.

- **Domain Layer** – Core business entities, DTOs, interfaces, and validation.
- **DomainService Layer** – Handles data retrieval with **ADO.NET** for optimized read operations (CQRS pattern).
- **Infrastructure.DAL Layer** – Manages data persistence (Insert/Update/Delete) using **Entity Framework Core**.
- **Infrastructure.Data Layer** – Contains EF Core `DbContext` and models (Database-First approach).
- **Utilities Layer** – Provides reusable helpers, extensions, and JWT handling.
- **API Layer** – Entry point, controllers, middlewares, services, and dependency injection.

This architecture ensures separation of concerns, CQRS pattern adoption, and flexible data access strategies.

---
## Security and Other details
[Sonali API Documentation](https://github.com/Tutul33/DemoAPI/blob/master/sonali_api_documentation.md)

---
## Database
[Database Download](https://drive.google.com/file/d/1im17SJuMNFCnU4DdxNs7047mh6Acvzzp/view?usp=sharing)

---
## Docker Build
[Docker Build Documentation](https://github.com/Tutul33/DemoAPI/blob/master/sonali_api_docker_setup.md)

---
## Kubernentes Orchestration 
[Docker Build Documentation](https://github.com/Tutul33/DemoAPI/blob/master/sonali_api_docker_setup.md)

---
## 🏗️ Project Structure

```
Sonali.API (Presentation Layer)
│── Controllers/        → API endpoints
│── Middlewares/        → Custom middlewares
│── Services/           → Application services
│── ServicesRegister/   → Dependency injection
│── appsettings.json    → Configuration
│── Program.cs          → Startup

Sonali.API.Domain (Domain Layer)
│── DTOs/               → Data Transfer Objects
│── Entities/           → Business entities
│── Interface/          → Abstractions
│── Validators/         → FluentValidation & business rules

Sonali.API.DomainService (Application Layer - Query side)
│── Base/               → Base services
│── DataService/        → ADO.NET-based query services
│── Interface/          → Service contracts
│── Repository/         → Read repositories

Sonali.API.Infrastructure.DAL (Infrastructure Layer - Command side)
│── Base/               → EF Core base classes
│── Repository/         → EF Core repositories for Insert/Update/Delete

Sonali.API.Infrastructure.Data (Database Layer)
│── Data/               → EF DbContext (Db-First)
│── Models/             → EF models

Sonali.API.Utilities (Shared Utilities)
│── EntityExtensions/   → Entity extension methods
│── Extensions/         → General extension methods
│── Helper/             → Utility/helper classes
│── Common.cs           → Shared constants & methods
│── JWTSettings.cs      → JWT configuration
```

---

## ⚙️ Technology Stack

- **.NET 8 (ASP.NET Core Web API)**
- **Entity Framework Core** (Database-First for persistence)
- **ADO.NET** (Optimized query handling for reads)
- **FluentValidation** (Validation layer)
- **JWT Authentication** (Secure API access)
- **Clean Architecture + CQRS pattern**

---

## 🚀 Getting Started

### 1️⃣ Prerequisites

- .NET 8 SDK
- SQL Server (or any configured DB)
- Visual Studio 2022 / VS Code

### 2️⃣ Setup & Run

```bash
# Clone repository
git clone <your-repo-url>
cd Sonali.API

# Restore dependencies
dotnet restore

# Build solution
dotnet build

# Run API
dotnet run --project Sonali.API
```

API will be available at:\
👉 `https://localhost:5001/swagger` (Swagger UI)

---

## 🔑 Authentication

**Uses JWT (JSON Web Tokens).**

- Configure `JWTSettings.cs` and `appsettings.json`.
- Pass JWT token via `Authorization: Bearer <token>` header.

---

## 📂 CQRS Implementation

- **Queries (Reads)** → DomainService (ADO.NET for performance)
- **Commands (Write operations)** → Infrastructure.DAL (EF Core for persistence)

This ensures optimized reads and maintainable writes.

---

## 🛠️ Utilities

- **Entity & General Extensions** → Reusable extension methods
- **Helper Classes** → Common functions
- **JWT Helpers** → Token generation & validation

---

## ✅ Advantages

- Clear separation of concerns
- CQRS support (Read/Write segregation)
- Easy to extend and maintain
- Testable and modular

---

## 📌 Future Improvements

- Add **Unit of Work** pattern for EF Core
- Add **MediatR** for CQRS command/query handling
- Introduce **Unit Tests / Integration Tests**
- Containerize with **Docker & Kubernetes**

---

## 📝 Example API Usage

### 1️⃣ Login

**POST** `/api/auth/login`

Request:

```json
{
  "UserName": "admin",
  "Password": "password123"
}
```

Response:

```json
{
  "token": "<jwt-token>",
  "expires": "2025-08-18T18:00:00Z"
}
```

**Use token in subsequent requests:**

```
Authorization: Bearer <jwt-token>
```

---

### 2️⃣ CRUD Sample (Voucher)

#### Create Voucher

**POST** `/api/vouchers`

```json
{
  "voucherNo": "V123",
  "userId": 1,
  "amount": 500.00,
  "date": "2025-08-18"
}
```

#### Read Vouchers

**GET** `/api/vouchers?userId=1&voucherNo=V123`

#### Update Voucher

**PUT** `/api/vouchers/1`

```json
{
  "amount": 600.00
}
```

#### Delete Voucher

**DELETE** `/api/vouchers/1`

---

This README provides a complete overview and onboarding guide for new developers.
# Sonali.API Architecture - Unit of Work & CQRS

## Architecture Diagram

```
                ┌─────────────────────┐
                │   VoucherController │
                │  (Thin Controllers) │
                └─────────┬───────────┘
                          │
       ┌──────────────────┴──────────────────┐
       │                                     │
       ▼                                     ▼
┌───────────────┐                     ┌─────────────────────┐
│DomainService  │                     │ IVoucherRepository  │
│(Query / Reads)│                     │ (Write / Commands) │
│ - GetVoucher  │                     │ - UpdateVoucher     │
│ - GetDetails  │                     │ - UpdateCheckApprove│
│ - GetCOA      │                     │ - ReferVoucher      │
└───────┬───────┘                     └─────────┬──────────┘
        │                                       │
        ▼                                       ▼
  Generic ADO.NET Factories               AppDbContext (EF Core)
  - Execute SPs                           - Tracks changes
  - Return DTOs                           - SaveChangesAsync() = Unit of Work
  - Optimized reads                       - Transactional writes
```

## Key Points

1. **CQRS Separation**

   - **Reads** → DomainService + ADO.NET (optimized, DTOs, SPs)
   - **Writes** → Repository + EF Core (Insert/Update/Delete)

2. **Unit of Work**

   - EF Core’s `DbContext` automatically tracks changes and ensures **transactional consistency** when `SaveChangesAsync()` is called.
   - Each controller request uses a scoped DbContext → naturally supports Unit of Work.

3. **Controller is thin**

   - Orchestrates calls to services/repositories.
   - No business logic here → easy to maintain.

4. **Why MediatR is optional**

   - You already have clear command/query separation.
   - Adding MediatR would introduce handlers/pipelines, but no new benefits in your current scale.

# Sonali.API - Unit & Integration Tests Guide

## 1️⃣ Create a Test Project

1. Right-click your solution → Add → New Project → xUnit Test Project (or NUnit).
2. Name it: `Sonali.API.Tests`
3. Add references to your main projects:
   - `Sonali.API` → for controllers
   - `Sonali.API.DomainService`
   - `Sonali.API.Infrastructure.DAL`
4. Add necessary NuGet packages:

```bash
dotnet add package Microsoft.EntityFrameworkCore.InMemory
dotnet add package Moq
dotnet add package Microsoft.AspNetCore.Mvc.Testing
dotnet add package AutoMapper
```

## 2️⃣ Recommended Folder Structure

```
Sonali.API.Tests
│
├── UnitTests
│   ├── Repository
│   │    └── VoucherRepositoryTests.cs
│   └── DomainService
│        └── AccountingDomainServiceTests.cs
│
└── IntegrationTests
     └── VoucherControllerIntegrationTests.cs
```

## 3️⃣ Test Project References

- `Sonali.API` → for integration tests (controllers, middleware, DI)
- `Sonali.API.DomainService` → for unit tests of your domain services (ADO.NET queries)
- `Sonali.API.Infrastructure.DAL` → for unit tests of repositories (EF Core commands)

### Why Not Add Tests to Original Layers

- Keeps production code clean (no xUnit, Moq, or test helpers).
- Avoids circular dependencies.
- Test project can use mocks, in-memory DB, or WebApplicationFactory.

### How to Add Reference

**Visual Studio:**

- Right-click `Sonali.API.Tests` → Add → Project Reference
- Check the boxes for `Sonali.API`, `Sonali.API.DomainService`, `Sonali.API.Infrastructure.DAL`
- Click OK

**CLI:**

```bash
cd Sonali.API.Tests
dotnet add reference ../Sonali.API/Sonali.API.csproj
dotnet add reference ../Sonali.API.DomainService/Sonali.API.DomainService.csproj
dotnet add reference ../Sonali.API.Infrastructure.DAL/Sonali.API.Infrastructure.DAL.csproj
```

---

## 4️⃣ Unit Tests

### Repository Unit Test Example

```csharp
using Xunit;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Sonali.API.Infrustructure.DAL.Repository;
using Sonali.API.Infrustructure.Data.Data;
using Sonali.API.Domain.DTOs;
using System.Threading.Tasks;
using System.Collections.Generic;

public class VoucherRepositoryTests
{
    private readonly AppDbContext _dbContext;
    private readonly IMapper _mapper;
    private readonly VoucherRepository _repository;

    public VoucherRepositoryTests()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDb")
            .Options;
        _dbContext = new AppDbContext(options);

        var config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<VoucherUpdateDTO, Accgl2025>().ReverseMap();
        });
        _mapper = config.CreateMapper();

        _repository = new VoucherRepository(_dbContext, _mapper);
    }

    [Fact]
    public async Task UpdateVoucher_ShouldAddNewVoucher()
    {
        var voucherList = new List<VoucherUpdateDTO> { new VoucherUpdateDTO { Id = 0, Tag = EntityState.Added, Damount = 100, Camount = 100 } };
        var result = await _repository.UpdateVoucher(voucherList);
        Assert.Single(result);
        Assert.Single(_dbContext.Accgl2025s);
        Assert.Equal(100, _dbContext.Accgl2025s.First().DAmount);
    }
}
```

### DomainService Unit Test Example

```csharp
using Moq;
using Xunit;
using Sonali.API.DomainService.Repository;
using Sonali.API.DomainService.Interface;
using Sonali.API.Domain.Entities;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

public class AccountingDomainServiceTests
{
    private readonly AccountingDomainService _service;
    private readonly Mock<IGenericFactoryMSSQL<Voucher>> _voucherRepoMock;

    public AccountingDomainServiceTests()
    {
        _voucherRepoMock = new Mock<IGenericFactoryMSSQL<Voucher>>();
        var voucherDtlRepoMock = new Mock<IGenericFactoryMSSQL<VoucherDtl>>();
        var coaRepoMock = new Mock<IGenericFactoryMSSQL<ChartOfAccounts>>();
        var fabUserRepoMock = new Mock<IGenericFactoryMSSQL<FinanceAndBankingUser>>();
        var loggerMock = new Mock<ILogger<AccountingDomainService>>();

        _service = new AccountingDomainService(
            _voucherRepoMock.Object,
            voucherDtlRepoMock.Object,
            coaRepoMock.Object,
            fabUserRepoMock.Object,
            loggerMock.Object
        );
    }

    [Fact]
    public async Task GetVoucherList_ShouldReturnVouchers()
    {
        _voucherRepoMock
            .Setup(x => x.ExecuteCommandListAsync(It.IsAny<string>(), It.IsAny<Dictionary<string, object?>>(), It.IsAny<string>()))
            .ReturnsAsync(new List<Voucher> { new Voucher { VoucherNo = "V001" } });

        var result = await _service.GetVoucherList(new VoucherSearchDTO());
        Assert.NotNull(result);
    }
}
```

## 5️⃣ Integration Tests

```csharp
using Xunit;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Sonali.API;

public class VoucherControllerIntegrationTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public VoucherControllerIntegrationTests(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task GetVoucherList_ReturnsSuccess()
    {
        var response = await _client.GetAsync("/api/Voucher/GetVoucherList");
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        Assert.Contains("list", content);
    }
}
```

## 6️⃣ Recommended Approach

| Test Type        | Layer                           | Tooling                       |
| ---------------- | ------------------------------- | ----------------------------- |
| Unit Test        | Repository (EF Core commands)   | XUnit + EF InMemory + Moq     |
| Unit Test        | DomainService (ADO.NET queries) | XUnit + Moq                   |
| Integration Test | API Controllers + Middleware    | XUnit + WebApplicationFactory |

## Database Link
https://drive.google.com/file/d/1vISzFDV8yXHbz7pLYNXk5PH2xk8mgqkY/view?usp=drive_link




