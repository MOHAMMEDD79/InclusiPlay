# InclusiPlay 🎮

A local interactive project designed to support inclusive play environments.

---

## 🧩 Database Setup (SQL Server)

### 1️⃣ Configure Connection
First, open `Connection.cs` and edit the connection string to match your PC settings.

### 2️⃣ Create the Database and Tables
Next, copy the following SQL script and execute it in **SQL Server Management Studio (SSMS)**:

```sql
-- إنشاء قاعدة البيانات (لو مش موجودة)
CREATE DATABASE Test;
GO

-- استخدام قاعدة البيانات
USE Test;
GO

---------------------------------------------------
-- جدول المستخدمين (MyTabel)
---------------------------------------------------
CREATE TABLE dbo.MyTabel (
    ID INT IDENTITY(1,1) PRIMARY KEY,       -- معرف تلقائي
    Name NVARCHAR(100) NOT NULL,            -- اسم المستخدم
    Password NVARCHAR(100) NOT NULL,        -- كلمة المرور
    Gender NVARCHAR(10) CHECK (Gender IN ('Male', 'Female')) NOT NULL
);
GO

---------------------------------------------------
-- جدول الرسائل (Messages)
---------------------------------------------------
CREATE TABLE dbo.Messages (
    ID INT IDENTITY(1,1) PRIMARY KEY,       -- معرف تلقائي لكل رسالة
    Username NVARCHAR(100) NOT NULL,        -- اسم المستخدم
    Message NVARCHAR(MAX) NOT NULL,         -- نص الرسالة
    SentAt DATETIME DEFAULT GETDATE()       -- وقت الإرسال التلقائي
);
GO

---------------------------------------------------
-- جدول المديرين (Managers)
---------------------------------------------------
CREATE TABLE dbo.Managers (
    ManagerID INT IDENTITY(1,1) PRIMARY KEY,
    FullName NVARCHAR(100) NOT NULL,
    Username NVARCHAR(100) UNIQUE NOT NULL,
    Password NVARCHAR(100) NOT NULL
);
GO

---------------------------------------------------
-- جدول السجلات (Logs)
---------------------------------------------------
CREATE TABLE dbo.Logs (
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    Action NVARCHAR(200),
    Username NVARCHAR(100),
    ActionDate DATETIME DEFAULT GETDATE()
);
GO
