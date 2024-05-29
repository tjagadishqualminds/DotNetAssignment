--drop database GroceriesAppdb

CREATE DATABASE GroceriesAppdb;

--creating table

CREATE TABLE Register (
    RegisterId INT IDENTITY(1,1),
    FirstName VARCHAR(20) NOT NULL,
    LastName VARCHAR(20) NOT NULL,
    Email VARCHAR(40) , -- Unique email
    [Password] VARCHAR(20) NOT NULL,
    ConfirmPassword VARCHAR(20) NOT NULL,
    PhoneNumber VARCHAR(15) NOT NULL, -- Unique phone number
    [Address] VARCHAR(60) NOT NULL, 
    City VARCHAR(30) NOT NULL,
    [State] VARCHAR(30) NOT NULL,
    PinCode VARCHAR(10) NOT NULL,
    DateRegistered DATETIME DEFAULT GETDATE(), -- Default to current date and time
    CONSTRAINT PK_Register_RegisterId PRIMARY KEY (RegisterId),
    CONSTRAINT UQ_Register_PhoneNumber UNIQUE (PhoneNumber),
    CONSTRAINT UQ_Register_RegisterEmail UNIQUE (Email)
);

SELECT * FROM Register;

--drop table Register;

INSERT INTO Register (
    FirstName, LastName, Email, [Password], ConfirmPassword, PhoneNumber,[Address], City, [State], PinCode
) VALUES
    ('John', 'Doe', 'john.doe@example.com', 'password123', 'password123', '+1234567890', '123 Main St', 'New York', 'NY', '10001'),
    ('Jane', 'Smith', 'jane.smith@example.com', 'password123', 'password123', '+0987654321', '456 Maple Ave', 'Los Angeles', 'CA', '90001');


	
CREATE TABLE [Login](
   LoginId INT IDENTITY(1,1),
   RegisterId INT NOT NULL,
   Email VARCHAR(40),
   [Password] VARCHAR(20) NOT NULL,
   CONSTRAINT UQ_Login_Email UNIQUE(Email),
   CONSTRAINT PK_Login_LoginId PRIMARY KEY(LoginId),
   CONSTRAINT FK_Login_Register FOREIGN KEY(RegisterId) REFERENCES Register(RegisterId)
);

drop table [Login]


INSERT INTO [Login](RegisterId,Email,[password]) VALUES
    (1, 'john.doe@example.com', 'password123'),
    (2, 'jane.smith@example.com', 'password123');

	SELECT * FROM [Login]

	CREATE TABLE Categories(
    CategoryId INT  IDENTITY(1,1),
	CategoryName VARCHAR(20)  NOT NULL,
	CONSTRAINT UQ_Categories_CategoryName UNIQUE (CategoryName),
	CONSTRAINT PK_Categories_CategoryId  PRIMARY KEY(CategoryId),

);

--drop table Categories;

INSERT INTO Categories( CategoryName) VALUES
    ( 'Fruits'),
    ( 'Vegetables'),
    ( 'Dairy');

SELECT * FROM Categories;


CREATE TABLE Products(
 ProductsId INT IDENTITY(1,1),
 ProductSupplierId INT,
 ProductName VARCHAR(20) NOT NULL,
 ProductPrice MONEY NOT NULL,
 ProductDescription VARCHAR(50) NOT NULL,
 ProductQuantity INT NOT NULL,
 CategoryId INT,
 CONSTRAINT FK_Products_Catergories FOREIGN KEY(CategoryId) REFERENCES Categories(CategoryId),
 CONSTRAINT FK_Products_Products_Supplier FOREIGN KEY(ProductSupplierId) REFERENCES Products_Supplier(ProductSupplierId),
 CONSTRAINT PK_Products_ProductId PRIMARY KEY(ProductsId),
);


INSERT INTO Products (ProductSupplierId, ProductName, ProductPrice, ProductDescription, ProductQuantity, CategoryId)
VALUES
(1, 'Apple', 0.50, 'Fresh Red Apple', 100, 1),
(2, 'Carrot', 0.20, 'Organic Carrot', 200, 2),
(5, 'Cheese', 2.00, 'Cheddar Cheese', 30, 3);

SELECT * FROM Products;


 -- Create the Supplier table
CREATE TABLE SupplierDetails (
    SupplierId INT IDENTITY(1,1) ,
    SupplierName VARCHAR(20) NOT NULL,
    [Password] VARCHAR(20) NOT NULL,
    ConfirmPassword VARCHAR(20) NOT NULL,
    Email VARCHAR(50) NOT NULL UNIQUE,
    PhoneNumber VARCHAR(15) NOT NULL UNIQUE,
    [Address] VARCHAR(60) NOT NULL,
    City VARCHAR(30) NOT NULL,
    [State] VARCHAR(30) NOT NULL,
    PinCode VARCHAR(10) NOT NULL,
    DateRegistered DATETIME DEFAULT CURRENT_TIMESTAMP,
	 CONSTRAINT UQ_SupplierDetails_PhoneNumber UNIQUE (PhoneNumber),
    CONSTRAINT UQ_SupplierDetails_RegisterEmail UNIQUE (Email),
	 CONSTRAINT PK_SupplierDetails_SupplierId PRIMARY KEY(SupplierId),

);


INSERT INTO SupplierDetails (SupplierName, [Password], ConfirmPassword, Email, PhoneNumber, [Address], City, [State], PinCode)
VALUES 
('Supplier One', 'password1', 'password1', 'supplier1@example.com', '1234567890', '123 Main St', 'Metropolis', 'NY', '10001'),
('Supplier Two', 'password2', 'password2', 'supplier2@example.com', '0987654321', '456 Elm St', 'Gotham', 'NJ', '10002');


SELECT * FROM SupplierDetails;


DROP TABLE SupplierDetails;
-- Create the Products_Supplier table
CREATE TABLE Products_Supplier (
    SupplierId INT,
    ProductSupplierId INT IDENTITY(1,1),
    ProductName VARCHAR(20) NOT NULL,
    ProductPrice MONEY NOT NULL,
    ProductDescription VARCHAR(50) NOT NULL,
    ProductQuantity INT NOT NULL,  
	CONSTRAINT FK_Product_Supplier_SupplierDetails FOREIGN KEY(SupplierId) REFERENCES SupplierDetails(SupplierId),
   CONSTRAINT PK_Products_Supplier_ProductSupplierId PRIMARY KEY(ProductSupplierId),	
);


-- Insert dummy data into Products_Supplier
INSERT INTO Products_Supplier (SupplierId, ProductName, ProductPrice, ProductDescription, ProductQuantity)
VALUES 
(1, 'Apple', 0.50, 'Fresh Red Apple', 100),
(1, 'Banana', 0.30, 'Fresh Yellow Banana', 150),
(2, 'Carrot', 0.20, 'Organic Carrot', 200),
(2, 'Tomato', 0.40, 'Fresh Red Tomato', 180),
(1, 'Cheese', 2.00, 'Cheddar Cheese', 30);



SELECT * FROM Products_Supplier;


CREATE TABLE [Orders](
OrderId INT IDENTITY(1,1),
ProductId INT NOT NULL,
LoginId INT,
OrderDate DATETIME DEFAULT GETDATE(), -- Default to current date and time
TotalAmount MONEY NOT NULL,
OrderStatus VARCHAR(20) NOT NULL,
CONSTRAINT FK_Orders_Login FOREIGN KEY(LoginId) REFERENCES [Login](LoginId),
CONSTRAINT PK_Orders_OrderId PRIMARY KEY(OrderId),
CONSTRAINT FK_Orders_Products FOREIGN KEY(ProductId) REFERENCES Products(ProductsId)
);
ALTER TABLE Orders
ADD CONSTRAINT FK_Orders_Products
FOREIGN KEY (ProductId) 
REFERENCES Products(ProductsId);
INSERT INTO Orders (ProductId, LoginId, TotalAmount, OrderStatus)
VALUES
(1, 1, 10.00, 'Processing'),   -- Order by John Doe for Apple
(2, 2, 20.00, 'Shipped'),      -- Order by Jane Smith for Carrot
(3, 1, 30.00, 'Delivered');   -- Order by John Doe for Cheese

SELECT * FROM Orders;


-- Create the Payment table
CREATE TABLE Payment (
    PaymentId INT IDENTITY(1,1),
    OrderId INT NOT NULL,
    PaymentDate DATETIME DEFAULT GETDATE(), -- Default to current date and time
    PaymentAmount MONEY NOT NULL,
    PaymentMethod VARCHAR(20) NOT NULL,
    PaymentStatus VARCHAR(20) NOT NULL,
    CONSTRAINT FK_Payment_Orders FOREIGN KEY (OrderId) REFERENCES Orders(OrderId),
	CONSTRAINT PK_Payment_PaymentId PRIMARY KEY(PaymentId),
);

-- Insert dummy data into Payment
INSERT INTO Payment (OrderId, PaymentAmount, PaymentMethod, PaymentStatus)
VALUES
(1, 10.00, 'Credit Card', 'Completed'),   -- Payment for Order 1
(2, 20.00, 'PayPal', 'Pending'),          -- Payment for Order 2
(3, 30.00, 'Debit Card', 'Completed');    -- Payment for Order 3

-- Verify the data insertion
SELECT * FROM Payment;

-- Verify all table data
SELECT * FROM Register;
SELECT * FROM [Login];
SELECT * FROM Categories;
SELECT * FROM SupplierDetails;
SELECT * FROM Products_Supplier;
SELECT * FROM Products;
SELECT * FROM Orders;
SELECT * FROM Payment;
