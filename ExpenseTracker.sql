--DB Design for ExpenseTracker API
USE master
GO

IF NOT EXISTS (SELECT 1 from sys.databases WHERE name = 'ExpenseTracker')
BEGIN
    -- Create Database
    CREATE DATABASE ExpenseTracker;
END
-- ELSE
-- BEGIN
--     --Drop Database
--     DROP DATABASE ExpenseTracker;
-- END
GO

-- Use the Database
USE ExpenseTracker;
GO

-- Family Table
CREATE TABLE Family(
    FamilyId INT IDENTITY(1, 1),
    FamilyName NVARCHAR(100) NOT NULL,
    CONSTRAINT PK_Family_FamilyId PRIMARY KEY (FamilyId)
);

-- User Profile Table
CREATE TABLE UserProfile(
    UserId INT IDENTITY(1, 1),
    -- If No display name, taken as a guest
    DisplayName NVARCHAR(100) NOT NULL CONSTRAINT DF_UserProfile_DisplayName DEFAULT 'Guest',
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    AddObjId NVARCHAR(120) NOT NULL,
    FamilyId INT NULL,
    CONSTRAINT PK_UserProfile_UserId PRIMARY KEY (UserId),
    CONSTRAINT FK_UserProfile_Family FOREIGN KEY (FamilyId) REFERENCES Family(FamilyId)
);

-- Expanse Type Table (card, cash, cheque)
CREATE TABLE ExpenseType(
    ExpenseTypeId INT IDENTITY(1, 1),
    ExpenseTypeName NVARCHAR(50) NOT NULL,
    CONSTRAINT PK_ExpenseType_ExpenseTypeId PRIMARY KEY (ExpenseTypeId)
);

-- Credit Card Table
CREATE TABLE CreditCard(
    CreditCardId INT IDENTITY(1, 1),
    CardLastFourDigit NVARCHAR(4) NOT NULL,
    CreditCardName NVARCHAR(50) NOT NULL,
    UserId INT,
    CONSTRAINT PK_CreditCard_CreditCardId PRIMARY KEY (CreditCardId),
    CONSTRAINT FK_CreditCard_UserProfile FOREIGN KEY (UserId) REFERENCES UserProfile(UserId)
);

-- Expense Category
CREATE TABLE ExpenseCategory(
    ExpenseCategoryId INT IDENTITY (1, 1),
    ExpenseCategoryName NVARCHAR(100) NOT NULL, --fruits, food, shopping....
    CONSTRAINT PK_ExpenseCategory_ExpenseCategoryId PRIMARY KEY (ExpenseCategoryId)
); 

-- Expense Table
CREATE TABLE Expense(
    ExpenseId INT IDENTITY(1, 1),
    UserId INT,
    ExpenseAmount DECIMAL(18, 2) NOT NULL,
    ExpenseCategoryId INT,
    ExpenseTypeId INT,
    CreditCardId INT,    
    ExpenseDescription NVARCHAR(500) NOT NULL,
    ExpenseDate DATETIME NOT NULL,
    CONSTRAINT PK_Expense_ExpenseTypeId PRIMARY KEY (ExpenseId)
);

-- Forgien Key Constraint for Expense Table
ALTER TABLE Expense
    ADD CONSTRAINT FK_Expense_User FOREIGN KEY (UserId) REFERENCES UserProfile(UserId),
        CONSTRAINT FK_Expense_Category FOREIGN KEY (ExpenseCategoryId) REFERENCES ExpenseCategory(ExpenseCategoryId),
        CONSTRAINT FK_Expense_Type FOREIGN KEY (ExpenseTypeId) REFERENCES ExpenseType(ExpenseTypeId),
        CONSTRAINT FK_Expense_CreditCard FOREIGN KEY (CreditCardId) REFERENCES CreditCard(CreditCardId)

-- Indexes for faster queries
CREATE INDEX IDX_Expense_UserId ON Expense(UserId);
CREATE INDEX IDX_Expense_FamilyId ON UserProfile(FamilyId);


