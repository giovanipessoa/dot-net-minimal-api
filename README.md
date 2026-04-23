# Appointment API - .NET Minimal API & Amazon RDS

This project is a technical laboratory designed to explore the **Minimal API** architecture in .NET Core, utilizing **Entity Framework Core** for data persistence on an **Amazon RDS (PostgreSQL)** instance within the Free Tier.

## What are Minimal APIs?

Introduced in .NET 6, Minimal APIs are a simplified approach to building HTTP services. They eliminate the "boilerplate" code associated with traditional MVC Controllers, allowing you to declare endpoints fluently and directly in the `Program.cs` file.

### Why use Minimal APIs?

1.  **Superior Performance:** Reduced overhead in the request pipeline compared to MVC/Controllers.
2.  **Low Ceremony:** Ideal for microservices, AWS Lambdas, and applications where simplicity and speed are priorities.
3.  **Code-First Focus:** Clearer visibility of routing logic and Dependency Injection in a single location.
4.  **Lean Architecture:** Perfect for high-performance services and modern cloud-native development.

---

## Tech Stack

-   **.NET Core 8.0+** (Current LTS/Current SDK)
-   **Entity Framework Core:** ORM for object-relational mapping.
-   **PostgreSQL:** Relational database hosted on AWS RDS.
-   **Data Annotations:** Schema validation and business rules applied directly to the entities.
-   **pgAdmin 4:** Database management and manual querying.

---

## When to use vs. When to avoid

| Scenario | Use Minimal API? | Justification |
| :--- | :--- | :--- |
| **Microservices** | Yes | Fast startup and reduced memory footprint. |
| **Serverless (AWS Lambda)** | Yes | Significantly lower "Cold Start" times. |
| **Small/Medium APIs** | Yes | Cleaner code and easier maintenance. |
| **Complex Monoliths** | Maybe | Requires organization via extension methods to prevent `Program.cs` clutter. |
| **MVC/Razor Views** | No | The MVC pattern is better suited for server-side UI rendering. |

---

## Environment Configuration

### 1. Requirements
-   AWS RDS instance set to **Publicly Accessible**.
-   RDS Security Group allowing inbound traffic on port **5432** for your specific IP.
-   Required NuGet Packages:
    - `Microsoft.EntityFrameworkCore`
    - `Npgsql.EntityFrameworkCore.PostgreSQL`
    - `Microsoft.EntityFrameworkCore.Design`

### 2. Connection String
Your `appsettings.json` should follow this template (excluded from version control for security):
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=<rds-endpoint>;Database=postgres;Username=<user>;Password=<pass>"
  }
}
