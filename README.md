# Products Management API

A clean and lightweight **RESTful Products Management API** built with **C# and ASP.NET Core**. The project demonstrates how to build, document, and test HTTP APIs using ASP.NET Core controllers, Swagger/OpenAPI, and in-memory data storage.

The API provides endpoints for creating a foundation for product management operations such as retrieving products, retrieving a product by ID, updating products, and deleting products.

---

## 🚀 Features

- RESTful API architecture
- Product management endpoints
- Get all products
- Get a product by ID
- Update an existing product
- Delete a product
- HTTP status code handling
- Model binding with ASP.NET Core
- Request validation through `[ApiController]`
- Swagger/OpenAPI API documentation
- Scalar API reference support
- In-memory product storage
- Clean controller/model separation

---

## 🛠️ Tech Stack

| Technology | Purpose |
|---|---|
| **C#** | Programming language |
| **ASP.NET Core** | Web API framework |
| **.NET 10** | Runtime / development platform |
| **Swagger** | API documentation and testing |
| **OpenAPI** | API specification |
| **Scalar** | Interactive API reference |
| **Rider** | Development environment |

---

## 📁 Project Structure

```text
ProductsManagement/
│
├── Controllers/
│   └── ProductsController.cs
│
├── Models/
│   └── Product.cs
│
├── Properties/
│   └── launchSettings.json
│
├── Program.cs
├── ProductsManagement.csproj
└── README.md
````

### Controllers

Contains the API controllers responsible for handling HTTP requests.

```text
Controllers/
└── ProductsController.cs
```

### Models

Contains the application's data models.

```text
Models/
└── Product.cs
```

### Program.cs

Responsible for configuring the ASP.NET Core application, registering services, configuring middleware, and mapping API controllers.

---

# 📦 Product Model

The API currently uses the following product structure:

```csharp
public class Product
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public required decimal Price { get; set; }
}
```

### Product Properties

| Property      | Type      | Description                  |
| ------------- | --------- | ---------------------------- |
| `Id`          | `int`     | Unique product identifier    |
| `Name`        | `string`  | Product name                 |
| `Description` | `string?` | Optional product description |
| `Price`       | `decimal` | Product price                |

---

# 🔌 API Endpoints

Base URL:

```text
http://localhost:5046
```

## Get All Products

```http
GET /api/products
```

Returns all available products.

### Example Response

```json
[
  {
    "id": 1,
    "name": "Laptop",
    "description": "Laptop is 12cm long",
    "price": 999.99
  },
  {
    "id": 2,
    "name": "SmartPhone",
    "description": null,
    "price": 499.99
  },
  {
    "id": 3,
    "name": "iWatch",
    "description": null,
    "price": 199.99
  }
]
```

---

## Get Product by ID

```http
GET /api/products/{id}
```

### Example

```http
GET /api/products/1
```

Returns the product matching the specified ID.

### Successful Response

```http
200 OK
```

### Product Not Found

```http
404 Not Found
```

---

## Update Product

```http
PUT /api/products/{id}
```

Updates an existing product.

### Example

```http
PUT /api/products/1
```

### Request Body

```json
{
  "id": 1,
  "name": "Updated Laptop",
  "description": "Updated product description",
  "price": 1099.99
}
```

### Successful Response

```http
204 No Content
```

### Product Not Found

```http
404 Not Found
```

---

## Delete Product

```http
DELETE /api/products/{id}
```

Deletes a product from the current in-memory collection.

### Example

```http
DELETE /api/products/3
```

### Successful Response

```http
204 No Content
```

### Product Not Found

```http
404 Not Found
```

---

# 📚 API Documentation

This project includes interactive API documentation using Swagger/OpenAPI.

After starting the application, open:

```text
http://localhost:5046
```

Swagger provides an interactive interface where you can:

* View available endpoints
* Inspect request/response models
* Send API requests
* Test GET requests
* Test PUT requests
* Test DELETE requests
* Inspect HTTP responses

---

# ▶️ Getting Started

## Prerequisites

Make sure you have the following installed:

* [.NET SDK](https://dotnet.microsoft.com/)
* Git
* JetBrains Rider, Visual Studio, or another C# IDE

Verify your .NET installation:

```bash
dotnet --version
```

---

## Clone the Repository

```bash
git clone https://github.com/your-username/ProductsManagement.git
```

Navigate into the project:

```bash
cd ProductsManagement
```

---

## Restore Dependencies

```bash
dotnet restore
```

---

## Build the Project

```bash
dotnet build
```

---

## Run the Application

```bash
dotnet run
```

The API will start on a local URL similar to:

```text
http://localhost:5046
```

---

# 🧪 Testing the API

You can test the API using:

* Swagger UI
* Scalar
* Postman
* cURL
* JetBrains Rider HTTP Client
* Browser for GET endpoints

### Example cURL Request

```bash
curl http://localhost:5046/api/products
```

Get a specific product:

```bash
curl http://localhost:5046/api/products/1
```

---

# 🏗️ Architecture

The application follows a simple controller-based ASP.NET Core architecture:

```text
                    Client
                      │
                      ▼
               HTTP Request
                      │
                      ▼
          ┌─────────────────────┐
          │ ProductsController  │
          └──────────┬──────────┘
                     │
                     ▼
              Product Model
                     │
                     ▼
             In-Memory Storage
                     │
                     ▼
               HTTP Response
```

The controller is responsible for:

* Receiving HTTP requests
* Processing route parameters
* Searching the product collection
* Updating products
* Removing products
* Returning appropriate HTTP responses

---

# 📡 HTTP Status Codes

The API uses standard HTTP status codes.

| Status Code       | Meaning                              |
| ----------------- | ------------------------------------ |
| `200 OK`          | Request completed successfully       |
| `204 No Content`  | Update/delete completed successfully |
| `404 Not Found`   | Requested product does not exist     |
| `400 Bad Request` | Invalid request                      |

---

# 💾 Data Storage

The current version uses an **in-memory `List<Product>`** for data storage.

This makes the project intentionally lightweight and useful for learning and demonstrating REST API concepts.

> ⚠️ Data stored in memory will be lost when the application stops or restarts.

A future version can replace the in-memory collection with a persistent database such as:

* PostgreSQL
* SQL Server
* MySQL
* SQLite

using **Entity Framework Core**.

---

# 🔮 Future Improvements

Planned improvements include:

* [ ] Add `POST /api/products`
* [ ] Add Entity Framework Core
* [ ] Add PostgreSQL database integration
* [ ] Add database migrations
* [ ] Add repository/service layers
* [ ] Add DTOs
* [ ] Add FluentValidation or advanced model validation
* [ ] Add global exception handling
* [ ] Add structured logging
* [ ] Add unit tests
* [ ] Add integration tests
* [ ] Add pagination
* [ ] Add product search and filtering
* [ ] Add authentication and authorization
* [ ] Add Docker support
* [ ] Add CI/CD with GitHub Actions
* [ ] Deploy the API to a cloud platform

---

# 🧠 What I Learned

This project was built to strengthen practical understanding of:

* C# fundamentals
* ASP.NET Core
* REST API design
* MVC/controller architecture
* HTTP methods
* Routing
* Model binding
* HTTP status codes
* Dependency injection concepts
* Swagger/OpenAPI
* API testing
* CRUD operations
* Project organization

---

# 📌 API Summary

| Method   | Endpoint             | Description       |
| -------- | -------------------- | ----------------- |
| `GET`    | `/api/products`      | Get all products  |
| `GET`    | `/api/products/{id}` | Get product by ID |
| `PUT`    | `/api/products/{id}` | Update product    |
| `DELETE` | `/api/products/{id}` | Delete product    |

---

# 👨‍💻 Author

**Engr. Ipaye Babatunde**

Software Engineer • Java Architect • Backend Specialist

* GitHub: [@engripaye](https://github.com/engripaye)
* LinkedIn: [Engr. Ipaye Babatunde](https://www.linkedin.com/in/engripayebabatunde)

---

## ⭐ Support

If you find this project useful for learning ASP.NET Core and REST API development, consider giving the repository a ⭐ on GitHub.

---

## 📄 License

This project is available for educational and demonstration purposes.

```

### One correction before you publish

Your current project has **GET, GET by ID, PUT, and DELETE**, but **not POST**. I deliberately did **not** put `POST` in the current API endpoint table so your README accurately reflects your code.

Also, your project is currently using **in-memory storage**, so this README presents it as a learning/portfolio API rather than pretending it already has a production database.

For your GitHub portfolio, I'd recommend the next progression:

**In-memory CRUD → Entity Framework Core → PostgreSQL → DTOs → validation → global exception handling → unit/integration tests → Docker → CI/CD.**

That would turn this from a basic tutorial project into a much stronger **professional ASP.NET Core backend project**.
```
