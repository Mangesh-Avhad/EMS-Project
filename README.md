# EmployeeHub – Full Stack Employee Management System

EmployeeHub is a **full stack Employee Management System (EMS)** built as part of the **CDAC Project**.  
It helps organizations manage **employees, departments, and attendance** with a secure, role-based platform.  

---

## 🔹 Tech Stack

### Backend (this repo)
- ⚡ ASP.NET Core 9 Web API
- 🗄️ Entity Framework Core 9 + MySQL (Pomelo)
- 🔐 JWT Authentication & Role-based Authorization
- 📚 AutoMapper for DTO mapping
- 🛠 Swagger for API documentation

### Frontend
- 🎨 React + Vite + TypeScript
- 📦 Material UI (MUI) for modern UI
- 🔗 Axios for API calls
- 🔑 Integrated with JWT authentication

👉 Frontend Repo: [EMS-Frontend](https://github.com/your-username/EMS-Frontend)

---

## 🚀 Features
- 🔑 User Authentication (Register / Login with JWT)
- 🏢 Department Management (CRUD APIs)
- 👨‍💼 Employee Management (CRUD APIs with department relation)
- 📅 Attendance Management (mark present/absent, view history)
- 🎯 Role-based Access Control (Admin vs Employee)
- 📖 Swagger UI for backend API testing

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

yaml
Copy code

---

## ⚡ Getting Started

### 1. Clone the Repo
```bash
git clone https://github.com/your-username/EMS-Backend.git
cd EMS-Backend
2. Configure Database
Update appsettings.json with your MySQL connection string:

json
Copy code
"ConnectionStrings": {
  "DefaultConnection": "server=localhost;database=employeedb;user=root;password=yourpassword;"
}
Run EF migrations:

bash
Copy code
dotnet ef migrations add InitialCreate
dotnet ef database update
3. Run the API
bash
Copy code
dotnet run
API will start on:

🔗 http://localhost:5041

🔒 https://localhost:7031

Swagger available at:
👉 https://localhost:7031/swagger

🔗 Running the Frontend
Clone the frontend repo in a separate folder:

bash
Copy code
git clone https://github.com/your-username/EMS-Frontend.git
cd EMS-Frontend
npm install
npm run dev
Frontend will start on 👉 http://localhost:5173
Make sure the backend is running before using the frontend.

👨‍💻 Author
Developed as part of CDAC Project – Employee Management System.
