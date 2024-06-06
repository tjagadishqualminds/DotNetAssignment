CREATE DATABASE GroceriesAppdb;
Use GroceriesAppdb;

--creating table

DROP TABLE UserDetails
CREATE TABLE  UserDetails(
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
	UserType VARCHAR(40) NOT NULL,
    DateRegistered DATETIME DEFAULT GETDATE(), -- Default to current date and time
    CONSTRAINT PK_UserDetails_RegisterId PRIMARY KEY (RegisterId),
    CONSTRAINT UQ_UserDetails_PhoneNumber UNIQUE (PhoneNumber),
    CONSTRAINT UQ_UserDetails_RegisterEmail UNIQUE (Email)
);



INSERT INTO UserDetails(
    FirstName, LastName, Email, [Password], ConfirmPassword, PhoneNumber,[Address], City, [State], PinCode, UserType
) VALUES
    ('John', 'Doe', 'john.doe@example.com', 'password123', 'password123', '+1234567890', '123 Main St', 'New York', 'NY', '10001', 'Customer'),
    ('Jane', 'Smith', 'jane.smith@example.com', 'password123', 'password123', '+0987654321', '456 Maple Ave', 'Los Angeles', 'CA', '90001', 'Customer'),
    ('Supplier One', 'Supplier', 'supplier1@example.com', 'password123', 'password123', '+9876543210', '789 Oak St', 'Chicago', 'IL', '60601', 'Supplier'),
    ('Supplier Two', 'Supplier', 'supplier2@example.com', 'password123', 'password123', '+0123456789', '321 Pine Ave', 'Miami', 'FL', '33101', 'Supplier');
	
-- Verify the data insertion
SELECT * FROM UserDetails;


CREATE TABLE Products_Supplier (
    ProductSupplierId INT IDENTITY(1,1),
    ProductName VARCHAR(20) NOT NULL,
    ProductPrice MONEY NOT NULL,
    ProductDescription VARCHAR(50) NOT NULL,
    ProductQuantity INT NOT NULL,
   CONSTRAINT PK_Products_Supplier_ProductSupplierId PRIMARY KEY(ProductSupplierId),	
);


-- Insert dummy data into Products_Supplier
INSERT INTO Products_Supplier ( ProductName, ProductPrice, ProductDescription, ProductQuantity)
VALUES 
( 'Apple', 0.50, 'Fresh Red Apple', 100),
( 'Banana', 0.30, 'Fresh Yellow Banana', 150),
( 'Carrot', 0.20, 'Organic Carrot', 200),
( 'Tomato', 0.40, 'Fresh Red Tomato', 180),
( 'Cheese', 2.00, 'Cheddar Cheese', 30);



-- Verify the data insertion
SELECT * FROM Products_Supplier;



	CREATE TABLE Categories(
    CategoryId INT  IDENTITY(1,1),
	CategoryName VARCHAR(20)  NOT NULL,
	CONSTRAINT UQ_Categories_CategoryName UNIQUE (CategoryName),
	CONSTRAINT PK_Categories_CategoryId  PRIMARY KEY(CategoryId),

);


INSERT INTO Categories( CategoryName) VALUES
    ( 'Fruits'),
    ( 'Vegetables'),
    ( 'Dairy');

	
-- Verify the data insertion
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
 CONSTRAINT PK_Products_ProductId PRIMARY KEY(ProductsId),
 CONSTRAINT FK_Products_ProductSupplierId FOREIGN KEY(ProductSupplierId) REFERENCES Products_Supplier(ProductSupplierId)
);



INSERT INTO Products (ProductSupplierId, ProductName, ProductPrice, ProductDescription, ProductQuantity, CategoryId)
VALUES
(1, 'Apple', 0.50, 'Fresh Red Apple', 100, 1),
(2, 'Carrot', 0.20, 'Organic Carrot', 200, 2),
(5, 'Cheese', 2.00, 'Cheddar Cheese', 30, 3);

-- Verify the data insertion
SELECT * FROM Products;



CREATE TABLE [Orders](
OrderId INT IDENTITY(1,1),
ProductId INT NOT NULL,
OrderDate DATETIME DEFAULT GETDATE(), -- Default to current date and time
TotalAmount MONEY NOT NULL,
OrderStatus VARCHAR(20) NOT NULL,
CONSTRAINT PK_Orders_OrderId PRIMARY KEY(OrderId),
CONSTRAINT FK_Orders_Products FOREIGN KEY(ProductId) REFERENCES Products(ProductsId)
);

INSERT INTO Orders (ProductId,  TotalAmount, OrderStatus)
VALUES
(1,10.00, 'Processing'),   -- Order by John Doe for Apple
(2,20.00, 'Shipped'),      -- Order by Jane Smith for Carrot
(3,30.00, 'Delivered');   -- Order by John Doe for Cheese


-- Verify the data insertion
SELECT * FROM Orders;


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
SELECT * FROM UserDetails;
SELECT * FROM Products_Supplier;
SELECT * FROM Categories;
SELECT * FROM Products;
SELECT * FROM Orders;
SELECT * FROM Payment;
