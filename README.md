# ☕ Coffee Shop Management System
### C# .NET 6 Windows Forms + SQLite

---

## 🚀 QUICK START (5 Steps)

### Step 1 — Prerequisites
Install the following if not already installed:
- **Visual Studio 2022** (Community Edition is free)
  - Workload: `.NET Desktop Development`
- **.NET 6 SDK** (usually included with VS 2022)
- **DB Browser for SQLite** (optional — to inspect the database)
  - Download: https://sqlitebrowser.org/dl/

---

### Step 2 — Open in Visual Studio
1. Extract the ZIP
2. Double-click `CoffeeShopMS.sln`  *(or open VS → File → Open → Project/Solution)*
3. Wait for NuGet packages to restore automatically

---

### Step 3 — Install NuGet Packages (if not auto-restored)
Open **Tools → NuGet Package Manager → Package Manager Console** and run:

```
Install-Package System.Data.SQLite.Core
Install-Package BCrypt.Net-Next
```

Or via GUI: right-click the project → Manage NuGet Packages → search and install:
- `System.Data.SQLite.Core`  (version 1.0.118)
- `BCrypt.Net-Next`          (version 4.0.3)

---

### Step 4 — Build & Run
1. Press **F5** or click the green ▶ Run button
2. The database file `CoffeeShop.db` is created automatically on first run
3. Login screen appears

---

### Step 5 — Default Login
| Field    | Value    |
|----------|----------|
| Username | admin    |
| Password | admin123 |

---

## 🗄️ DATABASE SCHEMA

```sql
-- Users table (BCrypt hashed passwords)
CREATE TABLE Users (
    Id       INTEGER PRIMARY KEY AUTOINCREMENT,
    Username TEXT    NOT NULL UNIQUE,
    Password TEXT    NOT NULL,          -- BCrypt hash
    Role     TEXT    NOT NULL DEFAULT 'Staff',
    Created  TEXT    NOT NULL DEFAULT (datetime('now'))
);

-- Products table
CREATE TABLE Products (
    Id          INTEGER PRIMARY KEY AUTOINCREMENT,
    Name        TEXT    NOT NULL,
    Category    TEXT    NOT NULL DEFAULT 'Coffee',
    Price       REAL    NOT NULL,
    Description TEXT,
    IsActive    INTEGER NOT NULL DEFAULT 1   -- soft delete
);

-- Orders table
CREATE TABLE Orders (
    Id           INTEGER PRIMARY KEY AUTOINCREMENT,
    OrderDate    TEXT    NOT NULL DEFAULT (datetime('now')),
    CustomerName TEXT,
    TotalAmount  REAL    NOT NULL DEFAULT 0,
    Status       TEXT    NOT NULL DEFAULT 'Pending',
    CreatedBy    INTEGER NOT NULL REFERENCES Users(Id)
);

-- OrderDetails table
CREATE TABLE OrderDetails (
    Id        INTEGER PRIMARY KEY AUTOINCREMENT,
    OrderId   INTEGER NOT NULL REFERENCES Orders(Id) ON DELETE CASCADE,
    ProductId INTEGER NOT NULL REFERENCES Products(Id),
    Quantity  INTEGER NOT NULL DEFAULT 1,
    UnitPrice REAL    NOT NULL,
    SubTotal  REAL    NOT NULL
);
```

---

## 📁 PROJECT STRUCTURE

```
CoffeeShopMS/
├── CoffeeShopMS.csproj          ← Project file (NuGet packages here)
├── CoffeeShopMS.sln             ← Solution file
├── Program.cs                   ← Entry point
├── Data/
│   └── DatabaseHelper.cs        ← SQLite connection + DB init + seeding
├── Models/
│   └── Models.cs                ← User, Product, Order, CartItem, Session
└── Forms/
    ├── LoginForm.cs             ← Login logic
    ├── LoginForm.Designer.cs    ← UI layout
    ├── LoginForm.resx
    ├── DashboardForm.cs         ← Dashboard + stats
    ├── DashboardForm.Designer.cs
    ├── DashboardForm.resx
    ├── ProductsForm.cs          ← CRUD for products
    ├── ProductsForm.Designer.cs
    ├── ProductsForm.resx
    ├── OrderForm.cs             ← New order (cart system)
    ├── OrderForm.Designer.cs
    ├── OrderForm.resx
    ├── BillingForm.cs           ← Bill receipt
    ├── BillingForm.Designer.cs
    ├── BillingForm.resx
    ├── OrdersListForm.cs        ← Order history
    ├── OrdersListForm.Designer.cs
    └── OrdersListForm.resx
```

---

## 🧩 FEATURES

| Module           | Features                                              |
|------------------|-------------------------------------------------------|
| **Login**        | BCrypt-verified login, session management             |
| **Dashboard**    | Live stats: products, orders today, revenue today     |
| **Products**     | Add / Edit / Soft-delete, search & filter by category |
| **New Order**    | Product list, cart, quantity, customer name           |
| **Billing**      | Receipt with itemized bill, print support             |
| **Order History**| Searchable orders, click to see line items            |

---

## 🔐 SECURITY

- Passwords stored as **BCrypt hashes** (never plain text)
- Default password `admin123` is hashed on first run
- Session object tracks logged-in user throughout the app

---

## 💡 VIVA TIPS

**Q: How does the DB get created?**  
A: `DatabaseHelper.InitializeDatabase()` in `Program.cs` runs on startup and creates tables + seeds data if the `.db` file doesn't exist.

**Q: Where is the DB file stored?**  
A: Same folder as the `.exe` — `bin/Debug/net6.0-windows/CoffeeShop.db`

**Q: Why BCrypt?**  
A: BCrypt is a one-way hash with a salt — even if someone steals the DB, they can't reverse the password.

**Q: What is soft-delete for products?**  
A: `IsActive=0` hides the product without physically deleting, so order history remains intact.

---

*Built with ☕ and C# — Clean Architecture, ZIP-ready*
