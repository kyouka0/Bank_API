# 🏦 Bank Management System (BMS)

## 📌 Mission Description
You are a software specialist at **Company X**. Your team has been assigned to develop a **Bank Management System (BMS)** using **Web API in .NET**.  
The goal of this system is to enable **bank employees, account holders, and administrators** to manage essential banking operations such as:

- Account creation  
- Transactions  
- Balance checks  

---

## 🎯 Core Requirements

### CRUD Operations
- Perform full CRUD operations on **Accounts**
- View **Transaction Histories**
- Manage overall **Bank Data**

### Architecture
Implement best practices including:
- DTOs (Data Transfer Objects)
- Repository Pattern
- Dependency Injection (DI)

### Security
- Enforce **Role-Based Access Control**
- Ensure **Secure Communication**

### Testing
- Verify application outputs using **thorough testing modules**

### Version Control
- Use **Git / Source Control** to track and manage changes

---

## ⚙️ 1. Set Up Environment
- Install required packages and libraries:
  - Entity Framework Core
  - SQL Server
- Configure:
  - `appsettings.json`
  - `Program.cs` (Connection Strings)

---

## 🗄️ 2. Data Models & Relationships

### Relationships
- **Customer ↔ Accounts**: One-to-Many  
- **Account ↔ Transactions**: One-to-Many  
- **Customer ↔ BankCard**: One-to-One  
- **Branch ↔ Employee**: Many-to-Many  

### Model Definitions

#### Customer
- CustomerId (Int, PK)
- Name (Required)
- Email (Required)
- PhoneNumber (Max 15)
- BankCardId (FK)

#### Account
- AccountId (Int, PK)
- AccountNumber (Required, Max 20)
- Balance (Required)
- CustomerId (FK)
- Transactions (Navigation Property)

#### Transaction
- TransactionId (Int, PK)
- Amount (Required)
- Date (Required, format: `yyyy-MM-dd`)
- AccountId (FK)

#### BankCard
- BankCardId (Int, PK)
- CardNumber (Required, Max 16)
- ExpiryDate (Required, format: `MM/yyyy`)
- CustomerId (FK)

#### Branch
- BranchId (Int, PK)
- Name (Required)
- Location (Required)
- Employees (Navigation Property)

#### Employee
- EmployeeId (Int, PK)
- Name (Required)
- Position (Required, e.g., "Manager")
- Branches (Navigation Property)

---

## 🌐 3. Controllers & API Endpoints

Each controller must:
- Support full CRUD operations
- Use DTOs
- Utilize the Repository Pattern through Dependency Injection

### CustomerController

#### GET `/api/customers`
- Returns a list of all customers including related Accounts, BankCards, and Transactions

#### POST `/api/customers`
- Adds a new Customer, Account, and BankCard  
- Required: Name, Contact, Email (Valid format)  
- Validation: Returns **400 Bad Request** if validation fails

#### GET `/api/customers/{id}`
- Retrieves a specific customer by Id including related data

### AccountController

#### GET `/api/accounts`
- Returns a list of all accounts including related Customer, BankCard, and Transactions

#### POST `/api/accounts`
- Adds a new account for a customer  
- Required: CustomerId, Initial Balance (Decimal)

---

## 🧩 4. Repository Pattern & Dependency Injection
- Create repository interfaces for all entities
- Implement concrete repository classes
- Register services in `Program.cs`
- Inject repositories into controllers
- Ensure correct HTTP status codes are returned

---

## 🧪 5. Testing and Validations

### Tools
- Swagger for API testing (GET, POST, PUT, DELETE)

### Testing Scenarios
- Design test scenarios and test cases
- Create **10 test cases** for attribute validation
- Document expected and actual results

---

## 🗂️ 6. Source Code Management
- Commit changes regularly
- Push/Pull updates to GitHub or Azure DevOps
- Use branches for updates and features
