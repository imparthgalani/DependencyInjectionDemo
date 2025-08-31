# Dependency Injection Lifetimes in ASP.NET Core 9 (with Swagger)

This project demonstrates the **Dependency Injection (DI) lifetimes** available in ASP.NET Core:

- `Transient`
- `Scoped`
- `Singleton`

It also includes **Swagger (Swashbuckle.AspNetCore 6.6.2)** for API documentation and testing.

---

## 📖 What are DI Lifetimes?

ASP.NET Core supports **three main DI lifetimes**:

1. **Transient**
   - A new instance is created each time it is requested.
   - Best for lightweight, stateless services.
   - Example: Calculation helpers, email formatters.

2. **Scoped**
   - A single instance is created per HTTP request.
   - The same instance is shared across the request pipeline.
   - Best for request-specific services, e.g., database repositories.

3. **Singleton**
   - A single instance is created and reused across the whole application.
   - Best for stateless and thread-safe services like logging, caching, configuration.

---

## 🚀 Getting Started

### 1️⃣ Clone Repository
```bash
git clone https://github.com/yourusername/DiLifetimesDemo.git
cd DiLifetimesDemo
