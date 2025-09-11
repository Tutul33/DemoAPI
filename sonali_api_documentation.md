# Sonali Life Insurance API Documentation

## 1. Overview
The Sonali Life Insurance API is built with **ASP.NET Core 8**, serving as the backend for managing insurance operations, user interactions, reporting, file uploads, and integration with banking and ERP systems. It uses **SignalR** for real-time communication, **Redis** for caching, **JWT** for authentication, **FluentValidation** for input validation, and **Rate Limiting** to prevent abuse.

## 2. Project Architecture

### 2.1 Layers
1. **API Layer**
   - Controllers handle HTTP requests and responses.
   - Middlewares handle cross-cutting concerns like authentication, validation, response wrapping, file validation, and error handling.

2. **Domain & Service Layer**
   - Business logic and domain services are defined here.
   - Validators enforce business rules using FluentValidation.

3. **Data Access Layer (DAL)**
   - `AppDbContext` with **Entity Framework Core** for SQL Server.
   - `RedisCacheService` for caching.
   - Repository pattern implemented for decoupling data access.

4. **Utilities & Helpers**
   - File management utilities.
   - JSON converters (e.g., `NullableDecimalConverter`).

5. **Real-time Communication**
   - `ChatHub` using **SignalR** to handle chat and active users.

## 3. Key Features

- **Authentication**: JWT-based.
- **File Upload**: Validates extensions and max size.
- **Rate Limiting**: Sliding window for login, fixed window for global requests.
- **Response Compression**: Gzip compression for JSON, CSV, XML, and plain text.
- **Swagger/OpenAPI**: API documentation with Bearer authentication.
- **Redis Integration**: Caching with health checks.
- **Static File Serving**: `/uploads`, `/reports/pdf`, `/reports/rdlc`.
- **Real-time Chat**: SignalR Hub with user connection tracking.

## 4. Middleware & Pipelines

| Middleware | Purpose |
|------------|---------|
| `ApiResponseMiddleware` | Wraps all responses in a consistent JSON format. Handles errors. |
| `JwtMiddleware` | Validates JWT tokens and attaches user claims. |
| `FileValidationMiddleware` | Validates uploaded files. |
| `FluentValidationActionFilter` | Validates request bodies using FluentValidation. |
| `RateLimiter` | Protects against DoS attacks and brute-force login attempts. |
| `ResponseCompression` | Compresses responses for performance improvement. |

**Pipeline Order**:
1. CORS
2. Rate Limiting
3. Custom Middlewares
4. Authentication/Authorization
5. Controllers
6. SignalR Hubs

## 5. API Design Considerations

**Strengths**:
- Layered architecture promotes maintainability.
- Centralized validation and response handling.
- Security controls: JWT, CORS, Rate Limiting.
- Redis caching for performance.
- AutoMapper simplifies DTO mapping.

**Potential Issues**:
1. **Static file exposure**: Serving `/uploads` without authentication could allow sensitive files to be accessed.
2. **Error Handling**: Sensitive exception details may leak in development mode.
3. **Rate Limiting**: X-Forwarded-For may be spoofed if not behind a trusted proxy.
4. **JWT Validation**: No refresh token strategy.
5. **Swagger in Production**: Should be disabled or secured.
6. **Redis ClearAllAsync**: Using `Keys("*")` can be slow in production.

## 6. Security Threats & Recommendations

| Threat | Description | Mitigation |
|--------|------------|------------|
| **Static File Leakage** | `/uploads` and `/reports` are publicly accessible. | Restrict to authenticated users, validate filenames. |
| **JWT Token Theft** | JWT may be intercepted. | Use HTTPS, short-lived tokens, refresh token mechanism. |
| **CSRF/XSS** | SignalR endpoints and APIs might be vulnerable. | Enable CSRF tokens, sanitize input/output. |
| **Brute-force login** | Weak passwords may be attempted repeatedly. | Sliding window rate limiting, captcha. |
| **Sensitive Data Exposure** | Stack traces or DB connection info may leak. | Disable detailed errors in production, log securely. |
| **Redis Injection** | If keys are user-controlled, may affect cache. | Validate keys, avoid dynamic key construction from input. |

## 7. Database & Caching
- **SQL Server**: Main database.
- **Entity Framework Core**: For insert/update/delete operations.
- **ADO.NET (Optional)**: For read-heavy GET operations.
- **Redis**: Key-value caching, connection health monitoring.

## 8. File Management
- Uploaded files stored under `FileUploadSettings.BasePath`.
- Report files stored under `ReportFileSettings.BasePath`.
- File size and extension validation applied.

## 9. SignalR Hub (`ChatHub`)
- Tracks active users in memory.
- Notifies all clients when users connect/disconnect.
- `GetConnectionId(username)` returns user connection ID.

**Potential improvement**:
- Persist active user info in Redis to scale across multiple instances.

## 10. Rate Limiting
- Global limiter: 100 requests/min per IP.
- Login limiter: 5 requests/min per IP using sliding window.
- Custom rejection message returned with `429 Too Many Requests`.

## 11. Swagger/OpenAPI
- JWT authorization configured.
- Development mode enabled.
- Production mode should restrict access.

## 12. Logging & Monitoring
- Redis monitoring service for cache health.
- Temporary file cleanup service.
- Consider adding request/response logging, structured logging, and metrics for Prometheus.

## 13. Recommendations
1. Serve static files behind authenticated endpoints or signed URLs.
2. Implement JWT refresh token flow.
3. Use trusted proxy headers for IP or implement user-based limits.
4. Log stack traces internally, avoid exposing sensitive info in API responses.
5. Avoid clearing all Redis keys in production.
6. Apply input sanitization and anti-forgery tokens.
7. Consider Redis backplane for SignalR scaling.

## 14. Conclusion
The API is **well-structured, modern, and secure for internal business use**, but attention should be given to **static file security, JWT management, Redis key safety, and logging practices** for production deployment. Proper monitoring, scaling, and security measures will ensure a robust system for banking and ERP integration.

