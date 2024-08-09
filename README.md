# CPW211-EntityFrameworkQueries

## Getting Started
- VS 2022
- .NET 8
- [AP Database](create_ap.sql) installed

- You may need to change the DB connection string located in the APContext Class
- by default it points to mssqllocaldb. If your AP script is not installed on mssqllocaldb, update your string.
- ```csharp
  optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AP");
  ```
