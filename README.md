# DOTNET/GraphQL/HOTCHOCOLATE

## Project setup

```bash
dotnet new web -n GraphRM
cd GraphRM
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package HotChocolate.AspNetCore
```

### Using SQLServer

```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```

### Makemigrations

Install the `dotnet ef` tool to create migrations.

```bash
dotnet tool install --global dotnet-ef
```

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```
