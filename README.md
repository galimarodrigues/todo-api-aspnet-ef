# ToDo API

A simple ToDo API built with ASP.NET Core, .NET 8, and Entity Framework. This API allows users to manage their to-do items, supporting CRUD operations.

## Features

- List all ToDos
- Get a ToDo by ID
- Create a new ToDo
- Update an existing ToDo
- Delete a ToDo

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- SQLite (or any other database of your choice)

### Installation

1. Clone the repository:
   ```bash
   git clone git@github.com:galimarodrigues/todo-api-aspnet-ef.git
   cd todo-api-aspnet-ef

2. Restore the dependecies:
   ```bash
   dotnet restore

3. Run the aplication: 
   ```bash
   dotnet run

## API Documentation

A API estará disponível em:
- **HTTP**: `http://localhost:5131`
- **HTTPS**: `https://localhost:7207`


### 1. Get All ToDos
- **Endpoint**: `GET /v1/todos`
- **Description**: Retrieves a list of all ToDo items.
- **Response**:
  - **200 OK**: Returns an array of ToDo objects.

### 2. Get ToDo by ID
- **Endpoint**: `GET /v1/todos/{id}`
- **Description**: Retrieves a ToDo item by its ID.
- **Parameters**:
  - `id` (int): The ID of the ToDo.
- **Response**:
  - **200 OK**: Returns the ToDo object.
  - **404 Not Found**: If the ToDo with the specified ID does not exist.

### 3. Create a New ToDo
- **Endpoint**: `POST /v1/todos`
- **Description**: Creates a new ToDo item.
- **Request Body**:
  ```json
  {
    "title": "Your ToDo Title"
  }
- **Response**:
  - **201 Created**: Returns the created ToDo object.
  - **400 Bad Request**: If the request body is invalid.

### 4. Update an Existing ToDo
- **Endpoint**: `PUT /v1/todos/{id}`
- **Description**: Updates an existing ToDo item.
- **Parameters**:
  - `id` (int): The ID of the ToDo to update.
- **Request Body**:
  ```json
  {
    "title": "Updated ToDo Title"
  }
- **Response**:
  - **200 OK**: Returns the updated ToDo object.
  - **404 Not Found**: If the ToDo with the specified ID does not exist.
  - **400 Bad Request**: If the request body is invalid.

### 5. Delete a ToDo
- **Endpoint**: `DELETE /v1/todos/{id}`
- **Description**: Deletes a ToDo item by its ID.
- **Parameters**:
  - `id` (int): The ID of the ToDo to delete.
- **Response**:
  - **200 OK**: Successfully deleted the ToDo.
  - **404 Not Found**: If the ToDo with the specified ID does not exist.
