# PatientTrackingSystem

# 🧠 AI-Supported Patient Tracking Platform (Lite)

This is a lightweight clinical monitoring system built with Angular 19 and .NET 8. It allows healthcare providers to manage patient records and leverage AI-driven prediction support (via a mock API). The system includes authentication, patient management features.

---

## 🚀 Project Features

### 🔐 Authentication
- JWT-based login system
- Secure API communication
- Route protection: unauthorized users cannot access patient records

### 👤 Patient Management
- View list of patients (Name, Surname, Birthdate)
- Add, update, and delete patients
- View patient details, history, doctor remarks

### 🤖 AI Prediction (Mock)
- AI prediction integration via mock API (`/api/Prediction/{patientId}`)
- Returns static prediction JSON for demo purposes

---

## 🛠️ Tech Stack

### 🧩 Frontend
- **Angular 19**
- **Reactive Forms**
- **JWT Auth + Route Guards**
- **HttpClient**

### 🖥️ Backend
- **.NET 8 (ASP.NET Core Web API)**
- **Entity Framework Core**
- **JWT Authentication**
- **Swagger API Documentation**

### 🗃️ Database
- **PostgreSQL 17**
---

## 🧪 Bonus Implementations (+1)

- ✅ Swagger API documentation (`/swagger`)
- ✅ Mock AI Prediction Endpoint
- ✅ Modular code architecture

