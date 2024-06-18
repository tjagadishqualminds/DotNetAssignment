CREATE DATABASE ECommerce;
Use ECommerce;
 
 
-- Creating table
CREATE TABLE UserDetails(
    UserDetailsId INT IDENTITY(1,1), 

    CreatedBy INT,
    UpdatedBy INT,
    FirstName VARCHAR(20) NOT NULL,
    LastName VARCHAR(20) NOT NULL,
    Email VARCHAR(40) NOT NULL, -- Unique email
    [Password] VARCHAR(20) NOT NULL,
    PhoneNumber VARCHAR(15) NOT NULL, -- Unique phone number
    [Address] VARCHAR(60) NOT NULL, 
    City VARCHAR(30) NOT NULL,
    [State] VARCHAR(30) NOT NULL,
    PinCode VARCHAR(10) NOT NULL,
    CreatedDate DATETIME DEFAULT GETDATE(), -- Default to current date and time
    UpdateDate DATETIME,
    CONSTRAINT PK_UserDetails PRIMARY KEY (UserDetailsId),
    CONSTRAINT UQ_UserDetails_PhoneNumber UNIQUE (PhoneNumber),
    CONSTRAINT UQ_UserDetails_RegisterEmail UNIQUE (Email)
);
 
-- Dummy data for UserDetails table
INSERT INTO UserDetails (
  CreatedBy, FirstName, LastName, Email, [Password], PhoneNumber, [Address], City, [State], PinCode
) VALUES (
    1,'John', 'Doe', 'john.doe@example.com', 'password123', '1234567890', '123 Main St', 'NewYork', 'WachingtonDC', '12345'
);
 
-- Verify the data insertion
SELECT * FROM UserDetails;
 
 
-- Creating table
CREATE TABLE Categories(
    CategoriesId INT IDENTITY(1,1),
    CreatedBy INT,
    UpdatedBy INT,
    CategoryName VARCHAR(20)  NOT NULL,
    CreatedDate DATETIME DEFAULT GETDATE(), -- Default to current date and time
    UpdateDate DATETIME,
    CONSTRAINT UQ_Categories_CategoryName UNIQUE (CategoryName),
    CONSTRAINT PK_Categories PRIMARY KEY(CategoriesId),
);
 
-- Dummy data for Categories table
INSERT INTO Categories(CreatedBy, CategoryName) VALUES
    ( 2,'Fruits'),
    ( 2,'Vegetables'),
    (2, 'Dairy');
 
-- Verify the data insertion
SELECT * FROM Categories;
 
 
 
-- Creating table
CREATE TABLE Products(
    ProductsId INT IDENTITY(1,1),
    CreatedBy INT,
    UpdatedBy INT,
    ProductName VARCHAR(20) NOT NULL,
    ProductPrice MONEY NOT NULL,
    ProductDescription VARCHAR(50) NOT NULL,
    ProductQuantity INT NOT NULL,
    CategoryId INT NOT NULL,
    CreatedDate DATETIME DEFAULT GETDATE(), -- Default to current date and time
    UpdateDate DATETIME,
    CONSTRAINT FK_Products_Categories FOREIGN KEY(CategoryId) REFERENCES Categories(CategoriesId),
    CONSTRAINT PK_Products PRIMARY KEY(ProductsId),
);
 
-- Dummy data for Products table
INSERT INTO Products ( CreatedBy,ProductName, ProductPrice, ProductDescription, ProductQuantity, CategoryId)
VALUES
(2,'Apple', 0.50, 'Fresh Red Apple', 100, 1),
(2,'Carrot', 0.20, 'Organic Carrot', 200, 2),
(2,'Cheese', 2.00, 'Cheddar Cheese', 30, 3);
 
-- Verify the data insertion
SELECT * FROM Products;
 
-- Creating table
CREATE TABLE [Orders](
    OrderId INT IDENTITY(1,1),
    CreatedBy INT,
    UpdatedBy INT,
    OrderBy INT,
    ProductId INT NOT NULL,
    Quantity INT,
    CreatedDate DATETIME DEFAULT GETDATE(), -- Default to current date and time
    UpdateDate DATETIME,
    TotalAmount MONEY NOT NULL,
    CONSTRAINT PK_Orders PRIMARY KEY(OrderId),
    CONSTRAINT FK_Orders_Products FOREIGN KEY(ProductId) REFERENCES Products(ProductsId),
    CONSTRAINT FK_Orders_UserDetails FOREIGN KEY(OrderBy) REFERENCES UserDetails(UserDetailsId),
);
 
-- Dummy data for Orders table
INSERT INTO Orders (CreatedBy,ProductId,Quantity, TotalAmount, OrderBy)
VALUES (1,1,2,19.99, 1);  -- Order by John Doe for Apple
 
-- Verify the data insertion
SELECT * FROM Orders;
 
-- Creating table
CREATE TABLE Payment (
    PaymentId INT IDENTITY(1,1),
	CreatedBy INT,
    UpdatedBy INT,
    OrderId INT NOT NULL,
    PaymentDate DATETIME DEFAULT GETDATE(), -- Default to current date and time
    PaymentAmount MONEY NOT NULL,
    PaymentMethod VARCHAR(20) NOT NULL,
    PaymentStatus VARCHAR(20) NOT NULL,
    CreatedDate DATETIME DEFAULT GETDATE(), -- Default to current date and time
    UpdateDate DATETIME,
    CONSTRAINT FK_Payment_Orders FOREIGN KEY (OrderId) REFERENCES Orders(OrderId),
    CONSTRAINT PK_Payment PRIMARY KEY(PaymentId),
);
 
-- Dummy data for Payment
INSERT INTO Payment (CreatedBy,OrderId,PaymentAmount, PaymentMethod, PaymentStatus)
VALUES
(1,1, 10.00, 'Credit Card', 'Completed'),   -- Payment for Order 1
(1,1, 9.99, 'PayPal', 'Pending'),          -- Payment for Order 1
(1,1, 30.00, 'Debit Card', 'Completed');    -- Payment for Order 1
 
-- Verify the data insertion
SELECT * FROM UserDetails;
SELECT * FROM Categories;
SELECT * FROM Products;
SELECT * FROM Orders;
SELECT * FROM Payment;