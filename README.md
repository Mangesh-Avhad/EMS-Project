# EMS-Backend

Backend for **Employee Management System (EMS)** built with:

- ⚡ [.NET 9](https://dotnet.microsoft.com/) Web API  
- 🗄️ [Entity Framework Core](https://learn.microsoft.com/ef/core/) + MySQL (Pomelo)  
- 🔐 JWT Authentication & Role-based Authorization  
- 📚 AutoMapper for DTO mapping  
- 🛠️ Swagger for API documentation  

---

## 🚀 Features
- 🔑 User Authentication (Register/Login with JWT)
- 🏢 Department Management (CRUD APIs)
- 👨‍💼 Employee Management (CRUD APIs with department relation)
- 📅 Attendance Management (CRUD APIs, mark present/absent)
- 🎯 Role-based Access Control (Admin vs Employee)
- 📖 Swagger UI for API testing

---

## 📂 Project Structure
EMS-Backend/
├── Controllers/ # API Controllers (Auth, Departments, Employees, Attendance)
├── Data/ # EMSContext (EF Core DbContext)
├── Models/ # Entities (User, Department, Employee, Attendance)
├── Repositories/ # Repository layer
├── Services/ # Business logic layer
├── DTOs/ # Data Transfer Objects
├── Mapping/ # AutoMapper profiles
├── Program.cs # Entry point (DI, Auth, Swagger, CORS setup)
└── appsettings.json # Config (DB connection, JWT secrets)

---

## ⚡ Setup & Run

### 1. Clone the Repo
```bash
git clone https://github.com/your-username/EMS-Backend.git
cd EMS-Backend
2. Configure Database

Update appsettings.json with your MySQL connection string:

"ConnectionStrings": {
  "DefaultConnection": "server=localhost;database=employeedb;user=root;password=yourpassword;"
}


Run EF migrations:

dotnet ef migrations add InitialCreate
dotnet ef database update

3. Run the API
dotnet run


API will start on:

🔗 http://localhost:5041

🔒 https://localhost:7031

Swagger available at:
👉 https://localhost:7031/swagger
🔗 Frontend

This backend powers the EMS-Frontend
 React app.

👨‍💻 Author

Developed as part of CDAC Project – Employee Management System.


---

✅ Now you have:
- **EMS-Backend repo** → with professional description & README.  
- **EMS-Frontend repo** → with professional description & README.  

Both look clean and consistent 🔥.  

---

👉 Do you want me to also create a **common top-level README** (EmployeeHub root README) in case you later want to combine both repos under one GitHub organization or monorepo?

