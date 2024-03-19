# GameStore API Study Notes

Welcome to my study notes on building a RESTful API with ASP.NET Core. The GameStore project is crafted as part of my journey to grasp the fundamentals and advanced concepts of RESTful APIs in the .NET ecosystem. This document is intended to serve as a personal guide and reference for anyone interested in learning alongside me or exploring my learning path.

## Introduction

The GameStore API project encompasses a practical approach to understanding RESTful principles, ASP.NET Core features, and best practices in API development. Through the creation and iteration of the GameStore project, these notes aim to document the setup process, key concepts, challenges encountered, and solutions devised.

## Project Setup

### Prerequisites
- .NET SDK (Ensure installation by running `dotnet --version` in the terminal)
- Visual Studio Code (VS Code) or any preferred IDE

### Initialization and Configuration
1. **Verify .NET SDK Installation**
    ```bash
    dotnet --version
    dotnet --info
    ```

2. **Start an ASP.NET Core Empty Project**
    ```bash
    dotnet new list
    ```
    Use the ASP.NET Core Empty project template for a minimal setup.

3. **Build and Run the Project**
    Navigate to the project directory:
    ```bash
    dotnet build
    dotnet run
    ```

## Core Concepts

### What is a REST API?
- REST APIs are architectural styles for designing networked applications, emphasizing resources and state management through HTTP requests.

### Understanding Minimal API in ASP.NET Core
- The project utilizes Minimal API to define HTTP endpoints with minimal boilerplate, ideal for learning and small to medium projects.

## Key Features and Implementations

- **Data Transfer Objects (DTOs)**
- **CRUD Operations**: Utilizing `WithName()` for route naming.
- **Extension Methods**: For common functionalities like database migrations.
- **Entity Framework Core**: ORM integration for data management.
- **Service Lifetimes**: Exploring Transient, Scoped, and Singleton lifetimes.
- **Asynchronous Programming**: Enhancing API performance.

## Learning Outcomes

- **Seeding Data**: Initializing the database with seed data.
- **Dependency Injection vs. Dependency Inversion**: Clarifying these fundamental concepts.
- **Object Mapping**: Translating between entities and DTOs.
- **Frontend Integration**: Basic guidelines for connecting with a frontend application.

## Conclusion

These notes encapsulate my learning experience with the GameStore API project. It's a living document, reflecting my ongoing exploration into ASP.NET Core and RESTful API development. I hope these insights assist you on your learning journey as well.

Feel free to reach out or contribute to these notes if you have suggestions, corrections, or insights of your own!

