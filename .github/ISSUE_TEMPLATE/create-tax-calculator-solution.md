## Create a .NET 9 Web Application for Income Tax Calculation (Clean Architecture)

### Description
Create a new .NET 9 solution for an income tax calculator, structured according to Clean Architecture principles. The solution should include the following projects:

#### Solution Structure
1. **TaxCalculator.Domain** - Core domain models and interfaces
2. **TaxCalculator.Application** - Application services and business logic
3. **TaxCalculator.Infrastructure** - Data access and external dependencies implementation
4. **TaxCalculator.Web** - ASP.NET Core MVC web application (Blazor, default template, "Hello world!" only)
5. **TaxCalculator.Tests** - Unit tests for the application

#### Technical Requirements
- **Frameworks/Libraries:**
  - .NET 9
  - Entity Framework Core (SQL Server)
  - Serilog for logging
  - Blazor
  - NUnit for testing
- **Design Patterns:**
  - Repository pattern
  - Dependency Injection
  - Clean Architecture

**Note:** All projects should be empty except `TaxCalculator.Web`, which should be a default Blazor web app displaying "Hello world!".

---

### Acceptance Criteria
- Solution and all projects are created as described
- `TaxCalculator.Web` runs and displays "Hello world!"
- No business logic or data access code is required at this stage
- All projects build successfully

---

### Additional Notes
- Use latest .NET 9 preview if stable is not available
- Use appropriate folder/project structure for Clean Architecture
- Prepare for future implementation of tax band configuration and calculation logic
