# Supermarket API ** Supermarket API **

A simple RESTful API to manage a super market catalogue. It is built with ASP.Net Core 3.1 following the principle of clean, decoupled and maintainable architecture.

#### Note: This project is created from a free tutorial I found online. Check out the complete guide in [freecodecamp.](https://www.freecodecamp.org/news/an-awesome-guide-on-how-to-build-restful-apis-with-asp-net-core-87b818123e28/)

## Work Flow
NA

## Environment Setup
1. Install [.NET Core 3.1](https://dotnet.microsoft.com/download)
2. Download [Visual Studio Code](https://code.visualstudio.com/), [Visual Studio Community](https://visualstudio.microsoft.com/downloads/) or any code editor of your choice. 
   
   If using VS Code, install [C# Extension](https://code.visualstudio.com/docs/languages/csharp) for better code highlighting.

## Database Connection
This project uses in-memory database. **No connection necessary**.

## Testing
1. Download [Postman.](https://www.postman.com/)
2. Using the terminal, go to your project directory and run it.

   `$ dotnet run`
3. Follow testing procedures in [freecodecamp.](https://www.freecodecamp.org/news/an-awesome-guide-on-how-to-build-restful-apis-with-asp-net-core-87b818123e28/).

## Resources
### Patterns Used
* [Repository Pattern](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/infrastructure-persistence-layer-design#the-repository-pattern)
* [Unit of Work Pattern](https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application)
### Frameworks and Libraries
* [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) as Object-Relational Mapping(ORM) and its [Fluent API](https://www.entityframeworktutorial.net/efcore/fluent-api-in-entity-framework-core.aspx) feature to specify database mapping.
* [Automapper](https://automapper.org/) to handle mapping between objects.
