# GameStore API Project

The GameStore project is a RESTful API developed with ASP.NET Core, designed for educational purposes to provide a deeper understanding of RESTful principles and ASP.NET Core features. This README outlines the setup process, key concepts, and steps to get started with the project.

## Project Setup

### Prerequisites
- .NET SDK (Check by running `dotnet --version` in your terminal)
- Visual Studio Code (VS Code) or another preferred code editor

### Getting Started
1. **Check .NET Installation**
    Open your terminal and verify the .NET SDK installation with the following commands:
    ```bash
    dotnet --version
    dotnet --info
    ```

2. **Create an ASP.NET Core Empty Project**
    Use the following command to list the available project templates and find the ASP.NET Core Empty project template:
    ```bash
    dotnet new list
    ```
   
3. **Build the Project**
    Navigate to your project directory and build the project to ensure everything is set up correctly:
    ```bash
    dotnet build
    ```
    Then, you can run the project:
    ```bash
    dotnet run
    ```

## What is a REST API?
REST (Representational State Transfer) API is an architectural style that conforms to REST architectural constraints. It's designed for networked applications to communicate over HTTP, with a focus on resources and state management. A resource in a REST API is any object or service that can be manipulated using HTTP requests.

## Using Minimal API

The GameStore project leverages the Minimal API feature of ASP.NET Core to simplify the API development process. This approach allows for defining HTTP endpoints with minimal boilerplate code, making it ideal for microservices and small applications.

### Features and Implementation

- **Data Transfer Objects (DTOs):** Define DTOs for transferring data between the client and server. DTOs help in exposing only the necessary data to the client.
  
- **CRUD Endpoints:** Implement Create, Read, Update, Delete (CRUD) operations using Minimal API. Use the `WithName()` method to assign names to routes for easier URL generation.

- **Using Extension Methods:** Apply extension methods like `MigrateDb` to encapsulate common functionality, such as applying database migrations at startup.

- **Handling Invalid Inputs:** Enhance API robustness by handling invalid input data. Utilize data annotations and endpoint filters for validation.

- **Entity Framework Core:** Integrate Entity Framework Core for ORM capabilities. Define the `GameStoreContext` for managing database operations.

- **Service Lifetimes:** Understand different service lifetimes (Transient, Scoped, Singleton) and their applications. Choose the appropriate lifetime based on the use case to manage dependencies in the application.

- **Asynchronous Programming:** Adopt asynchronous programming models to improve the scalability and performance of your API.

## Seeding Data and CRUD Operations

The project includes examples of seeding initial data into the database and performing CRUD operations on `Game` entities. Explore the Git commits linked in the README for detailed implementation steps and code changes.

## API Integration with Front End

While this project focuses on the backend API development, integrating the API with a frontend application involves calling the API endpoints from the frontend code, handling responses, and updating the UI accordingly. The specifics of this integration depend on the frontend technology stack being used.

## Conclusion

The GameStore API project offers a practical way to learn about building RESTful APIs with ASP.NET Core. By following the setup instructions and exploring the implemented features, you'll gain valuable insights into API development, ASP.NET Core capabilities, and RESTful design principles.
