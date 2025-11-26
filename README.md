# **Online Quiz Management System – Full Project Overview**

This repository contains the complete Online Quiz Management System, including both the **Backend API** (C#/.NET) and the **Frontend Application** (Angular).
The system enables faculties to create and manage quizzes, while students can take quizzes, submit answers, and track their performance.
Each sub-project (backend & frontend) includes its **own detailed README**, while this root README provides a concise, high-level overview of the entire system.

---

## 🚀 **Project Architecture**

The project follows a **full-stack architecture**:

### **Backend – C# / .NET**

* Layered architecture
* Entity Framework Core for data access
* AutoMapper for DTO/entity mapping
* JWT-based authentication & role-based authorization
* RESTful API controllers
* SQL Server database

### **Frontend – Angular**

* Component-based architecture
* Role-based UI (Student/Faculty)
* AuthGuard + Token-based route protection
* Services for API communication
* Bootstrap/Tailwind (if used) for UI
* Reactive forms + REST API integration

Both applications communicate via secure HTTP API calls.

---

## 🧩 **Tech Stack**

### **Backend**

* C# / .NET 7
* Entity Framework Core
* AutoMapper
* SQL Server
* REST API

### **Frontend**

* Angular 17+
* TypeScript
* RxJS
* Bootstrap / SCSS
* Angular Router & Guards

---

## 📂 **Project Structure (Overall)**

```
root
|-- OnlineQuizFrontend/       → Full Angular application
|   |-- src/
|   |-- ... (detailed in its own README)
|
|-- OnlineQuizBackend/        → Complete .NET backend API
|   |-- BusinessLogicLayer/
|   |-- DataAccessLayer/
|   |-- PresentationLayer/
|   |-- ... (detailed in its own README)
|
|-- README.md                 → (This file) Project overview
```

Each subfolder has its own detailed README with file descriptions, setup instructions, and architecture details.

---

## 🧪 **Core Features**

### ✅ **Common**

* Secure login system
* Role-based authorization (Student / Faculty)
* Token-based session management
* Clean API–client separation

### 👨‍🏫 Faculty Features

* Create quizzes
* Add questions & options
* Manage students & courses
* View quiz submissions & performance

### 👨‍🎓 Student Features

* View available quizzes
* Start quiz attempts
* Submit answers
* View score & quiz timeline

---

## ▶️ **How to Run the Full Project**

### **Backend (.NET)**

Go to backend folder:

```sh
cd OnlineQuizBackend/PresentationLayer
```

**Run:**

```sh
dotnet run
```

### **Frontend (Angular)**

Go to frontend folder:

```sh
cd OnlineQuizFrontend
```

**Install packages:**

```sh
npm install
```

**Run the app:**

```sh
ng serve
```

The Angular UI will run on:

```
http://localhost:4200
```

The .NET API (typically):

```
http://localhost:5000
```

---

## 🔗 **Integration Flow (Frontend ↔ Backend)**

1. User logs in → Angular sends request → Backend verifies credentials
2. Backend returns token → Angular stores token (cookie/localStorage)
3. AuthGuard protects routes → Only valid users can navigate
4. Angular services call backend APIs for quizzes, questions, students, etc.
5. Backend returns DTO responses mapped from entities
6. Angular renders UI based on role (Student/Faculty)

---

## 📘 **Documentation**

Each part of the project contains its **own detailed README**:

* `/OnlineQuizFrontend/README.md`:
  Full Angular architecture, components, services, guards, folder structure, and file descriptions.

* `/OnlineQuizBackend/README.md`:
  Complete layered architecture, services, Repos, DTOs, entity definitions, and API controller details.

This root README only provides a **unified high-level project view**.

---

## 📌 **Future Enhancements**

* Leaderboards
* Timed quiz with countdown
* Real-time monitoring
* Export reports (PDF/Excel)
* Notifications system

---

## 🏁 **Conclusion**

This full-stack Online Quiz System is built with scalable, modular architecture and clean separation of concerns.
Use this root README for **overall understanding**, and the individual READMEs for **deep technical documentation**.

---
