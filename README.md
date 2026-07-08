# CrewCloud — Human Resource Management System

**Windows-based HRMS built with .NET (WPF) to automate the employee lifecycle.**

CrewCloud is a desktop HR management system that automates core employee lifecycle processes — attendance, leave, payroll, and reporting — with role-based access control and audit-ready reporting for organisations that need a reliable, secure on-premise solution.

---

## Overview

CrewCloud streamlines day-to-day HR operations by centralising attendance tracking, leave management, payroll processing, and reporting into a single desktop application. Built with data integrity and security as core requirements, it uses role-based access control so Admins, HR Managers, and Employees each see only what's relevant to their role.

---

## Key Features

- **Attendance Management** — Tracks and records employee attendance.
- **Leave Management** — Handles leave requests, approvals, and balances.
- **Payroll Processing** — Automates payroll calculations tied to attendance and leave records.
- **Role-Based Access Control** — Separate permission levels for Admins, HR Managers, and Employees.
- **Audit-Ready PDF Reports** — Generates structured reports using PdfSharp for compliance and record-keeping.
- **Secure Authentication** — Passwords hashed with PBKDF2 (SHA-256); all database queries parameterized to prevent SQL injection.

---

## Tech Stack

| Layer | Technology |
|---|---|
| **Framework** | .NET (WPF) |
| **Language** | C# |
| **ORM** | Entity Framework Core |
| **Database** | SQL Server |
| **Querying** | LINQ |
| **Reporting** | PdfSharp |
| **Version Control** | Git & GitHub |

---

## How It Works

1. **Data Layer** — Entity Framework Core maps application models to SQL Server tables, handling migrations and queries via LINQ.
2. **Access Control** — Each user is assigned a role (Admin, HR Manager, Employee) that determines which views and actions are available.
3. **Security** — User passwords are hashed with PBKDF2 (SHA-256) before storage; all queries are parameterized to prevent SQL injection.
4. **Reporting** — PdfSharp generates audit-ready PDF reports from attendance, leave, and payroll data.

---

## Getting Started

### Prerequisites
- .NET SDK
- SQL Server (local or remote instance)
- Visual Studio (recommended for WPF development)

### Setup
```bash
git clone <repo-url>
cd CrewCloud
```
Update the connection string in the configuration file to point to your SQL Server instance, then run Entity Framework Core migrations:
```bash
dotnet ef database update
```
Open the solution in Visual Studio and run the project.

---

## Future Improvements

- Cloud-hosted version for multi-location access
- Employee self-service mobile companion app
- Automated payroll tax calculations by jurisdiction
- Dashboard analytics for HR metrics

---

