# ASP.NET Core Web API Project

This is a web API project built with .NET 10.0, ASP.NET Core, and C# 14.0.

## Features

- **Controllers**: RESTful API endpoints.
- **Health Checks**: Built-in health monitoring.
- **OpenAPI**: Integrated documentation for API discovery and testing.

## Getting Started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

### Running the Application

1. Clone the repository.
2. Navigate to the project directory.
3. Run the following command:

   ```bash
   dotnet run
   ```

The application will start and listen for HTTPS requests.

## API Endpoints

- **Health Check**: `GET /health`
  - Returns the status of the application.
- **OpenAPI Documentation**: Available at `/openapi/v1.json` (Development environment only).

## Project Structure

- `Program.cs`: The entry point of the application, configuring services and the request pipeline.
- `Controllers/`: Contains the API controllers for handling incoming requests.