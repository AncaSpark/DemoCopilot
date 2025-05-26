# Copilot Instructions for C#, Blazor, and Entity Framework
Best Practices for C#, Blazor, and Entity Framework

C#:
- Use meaningful naming conventions for variables, methods, and classes.
- Prefer async/await for I/O-bound operations.
- Implement exception handling using try-catch blocks.
- Use interfaces and dependency injection for testability.
- Keep methods short and focused on a single responsibility.
- Use access modifiers (private, public, etc.) appropriately.
- Write unit tests for business logic.

Blazor:
- Use components to encapsulate UI logic and promote reusability.
- Avoid placing business logic in Razor components; use services instead.
- Use @code blocks for C# logic, and keep UI markup clean.
- Use cascading parameters and dependency injection for state management.
- Prefer asynchronous methods for data fetching.
- Use partial classes for large components to separate logic from markup.
- Dispose resources properly by implementing IDisposable.

Entity Framework:
- Use DbContext per request or per operation, not as a singleton.
- Prefer async database operations (e.g., ToListAsync, SaveChangesAsync).
- Use migrations for schema changes.
- Avoid exposing DbSet directly; use repositories or services.
- Use NoTracking queries for read-only operations to improve performance.
- Validate user input to prevent SQL injection, even with EF.
- Avoid loading unnecessary related data (use Include/ThenInclude judiciously).
- Use transactions for multiple related database operations.

General:
- Follow SOLID principles.
- Use logging for error tracking and diagnostics.
- Secure sensitive data and use authentication/authorization.
- Keep dependencies updated and monitor for vulnerabilities.
*/