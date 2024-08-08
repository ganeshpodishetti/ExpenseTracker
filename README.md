.Net Core Expense Tracker Web API using EF Core, SQL, ADO.Net, LINQ and N-Tier Architecture
===
### Abstract: A robust and scalable Expense Tracker API built with .NET Core 8, designed to help users track and manage their expenses efficiently. This project demonstrates the use of modern software architecture practices including microservices, N-tier layers, and asynchronous programming with async/await. It integrates with Azure AD B2C for authentication and leverages Entity Framework Core for database operations.

## Key Points
- N-Tier Layer Architecture
- DB First approach

## Technologies Used
- .Net Core
- EF Core
- SQL Server
- RESTful API
- Azure AD B2C

## Commands used
- Create web api using command line 
  ```
  dotnet new webapi --name ExpenseTracker
  ```
- Add packages
  ```
  dotnet add package Microsoft.EntityFrameworkCore
  ```
- Build
  ```
  dotnet build
  ```
- Run
  ```
  dotnet run
  ```
- ```dotnet ef dbcontext scaffold``` is used to generate Entity Framework Core (EF Core) model classes from an existing database. This process is often referred to as "reverse engineering" the database schema into EF Core code.
  ```
  dotnet ef dbcontext scaffold "Data Source=localhost;Initial Catalog=ExpenseTracker; User Id=SA;Password=your password#;MultipleActiveResultSets=True; TrustServerCertificate=true" Microsoft.EntityFrameworkCore.SqlServer -o Models
  ```
- Ensure EF Core Tools Are Installed: Before running the command, ensure you have the EF Core tools installed:
  ```
  dotnet tool install --global dotnet-ef
  ```
  
## Pretrained model
| Model | Download |
| ---     | ---   |
| Model-1 | [download]() |
| Model-2 | [download]() |
| Model-3 | [download]() |

## Code Details

