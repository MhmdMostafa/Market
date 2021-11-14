CREATE DATABASE market;
USE market;

CREATE TABLE continents(
	ContinentID INT NOT NULL AUTO_INCREMENT,
    ContinentNameEN VARCHAR(50) NOT NULL,
    ContinentNameAR VARCHAR(50) NOT NULL,
    PRIMARY KEY (ContinentID)
);

CREATE TABLE countries(
	CountryID INT NOT NULL AUTO_INCREMENT,
    ContinentID INT NOT NULL,
    CountryCallingCodeID VARCHAR NOT NULL,
    CountryNameEN VARCHAR(50) NOT NULL,
    CountryNameAR VARCHAR(50) NOT NULL,
    PRIMARY KEY (CountryID),
    FOREIGN KEY (ContinentID) REFERENCES Continents(ContinentID),
    UNIQUE (CountryCallingCodeID)
);

CREATE TABLE contact_type(
	ContactTypeID INT AUTO_INCREMENT,
	ContactNameEN VARCHAR(50) NOT NULL,
	ContactNameAR VARCHAR(50) NOT NULL,
	PRIMARY KEY (ContactTypeID)
);

CREATE TABLE hands(
	HandID INT AUTO_INCREMENT,
	HandNameEN VARCHAR(50) NOT NULL,
	HandNameAR VARCHAR(50) NOT NULL,
	PRIMARY KEY (HandID)
);

CREATE TABLE hand_fingers(
	FingerID INT AUTO_INCREMENT,
	HandID INT,
	FingerNameEN VARCHAR(50) NOT NULL,
	FingerNameAR VARCHAR(50) NOT NULL,
	PRIMARY KEY (FingerID),
    FOREIGN KEY (HandID) REFERENCES hands(HandID)
);

CREATE TABLE currencies(
	CurrencyID INT NOT NULL AUTO_INCREMENT,
    CountryID INT NOT NULL,
    CurrencyNameEN VARCHAR(100) NOT NULL,
    CurrencyNameAR VARCHAR(100) NOT NULL,
    CurrencyShortCut NCHAR(6) NOT NULL,
    PRIMARY KEY (CurrencyID),
    FOREIGN KEY (CountryID) REFERENCES countries(CountryID)
);

CREATE TABLE invoice_type(
	InvoiceTypeID INT NOT NULL AUTO_INCREMENT,
    InvoiceTypeNameEN VARCHAR(50) NOT NULL,
    InvoiceTypeNameAR VARCHAR(50) NOT NULL,
    PRIMARY KEY (InvoiceTypeID)
);

CREATE TABLE payment_methods(
	PaymentMethodID int NOT NULL AUTO_INCREMENT,
    PaymentMethodNameEN VARCHAR(50) NOT NULL,
    PaymentMethodNameAR VARCHAR(50) NOT NULL,
    PRIMARY KEY (PaymentMethodID)
);

CREATE TABLE payment_mechanisms(
	PaymentMechanismeID INT NOT NULL AUTO_INCREMENT,
    PaymentMechanismeNameEN VARCHAR(50) NOT NULL,
    PaymentMechanismeNameAR VARCHAR(50) NOT NULL,
    PRIMARY KEY (PaymentMechanismeID)
);

CREATE TABLE products_units_value(
	UnitValueID INT NOT NULL AUTO_INCREMENT,
	UnitValueName VARCHAR(30) NOT NULL,
	UnitsValueShortCut VARCHAR(10) NOT NULL,
    PRIMARY KEY (UnitValueID)
);

CREATE TABLE products_groub(
	ProductGroubID INT NOT NULL AUTO_INCREMENT,
	ProductGroubNameEN VARCHAR(50) NOT NULL,
	ProductGroubNameAR VARCHAR(50) NOT NULL,
    PRIMARY KEY (ProductGroubID)
);

CREATE TABLE products_type(
	ProductTypeID INT NOT NULL AUTO_INCREMENT,
	ProductTypeNameEN VARCHAR(50) NOT NULL,
	ProductTypeNameAR VARCHAR(50) NOT NULL,
    PRIMARY KEY (ProductTypeID)
);


CREATE TABLE emp_group(
	EmpGroupID INT NOT NULL AUTO_INCREMENT,
    EmpGroupNameEN VARCHAR(50) NOT NULL,
    EmpGroupNameAR VARCHAR(50),
    PRIMARY KEY (EmpGroupID)
);

CREATE TABLE emp_permissions(
	PermissionID INT NOT NULL AUTO_INCREMENT,
    PermissionNameEN VARCHAR(50) NOT NULL,
    PermissionNameAr VARCHAR(50) NOT NULL,
    PRIMARY KEY (PermissionID)
);

CREATE TABLE emp_group_permissions(
	EmpGroupID INT,
    PermissionID INT,
    PermissionState BOOLEAN DEFAULT FALSE,
    FOREIGN KEY (EmpGroupID) REFERENCES emp_group(EmpGroupID),
    FOREIGN KEY (PermissionID) REFERENCES emp_permissions(PermissionID)
);

CREATE TABLE emp_employees(
	EmpID INT NOT NULL AUTO_INCREMENT,
	EmpGroupID INT,
    UserName VARCHAR(50),
	EmpNameEN VARCHAR(50) NOT NULL,
    EmpNameAR VARCHAR(50) ,
	DateOfBirh DATE,
    Password VARCHAR(25) NOT NULL,
    PRIMARY KEY (EmpID),
    FOREIGN KEY (EmpGroupID) REFERENCES emp_group(EmpGroupID),
    UNIQUE (UserName)
);

CREATE TABLE emp_email_addresses(
	EmpID INT NOT NULL,
    EmailAddress VARCHAR(150) NOT NULL,
    FOREIGN KEY (EmpID) REFERENCES emp_employees(EmpID),
    UNIQUE (EmailAddress)
);

CREATE TABLE emp_contact_numbers(
	EmpID INT NOT NULL,
    CountryID INT NOT NULL,
    ContactTypeID INT NOT NULL,
    ContactNumber VARCHAR(10) NOT NULL,
    FOREIGN KEY (EmpID) REFERENCES emp_employees(EmpID),
    FOREIGN KEY (CountryID) REFERENCES countries(CountryID),
    FOREIGN KEY (ContactTypeID) REFERENCES contact_type(ContactTypeID),
    UNIQUE (ContactNumber)
);

CREATE TABLE emp_bank_accounts(
	EmpID INT NOT NULL,
    BankNameAR VARCHAR(100) NOT NULL,
    BankNameEN VARCHAR(100) NOT NULL,
    BankIban VARCHAR(24) NOT NULL,
    FullNameOnwer VARCHAR(100) NOT NULL,
    ExpiryDate DATE NOT NULL,
    FOREIGN KEY (EmpID) REFERENCES emp_employees(EmpID)
);

CREATE TABLE emp_Addresses(
	EmpID INT NOT NULL,
    CountryID INT NOT NULL,
    District VARCHAR (45) NOT NULL,
    Street VARCHAR (45) NOT NULL,
    Description VARCHAR (100) NOT NULL,
    FOREIGN KEY (CountryID) REFERENCES Countries(CountryID),
    FOREIGN KEY (EmpID) REFERENCES emp_employees(EmpID)
);

CREATE TABLE emp_fingerprints(
	EmpID INT NOT NULL,
    HandID INT,
    FingerID INT,
    FingerPrint BLOB NOT NULL,
    FOREIGN KEY (EmpID) REFERENCES emp_employees(EmpID),
    FOREIGN KEY (HandID) REFERENCES hands(HandID),
    FOREIGN KEY (FingerID) REFERENCES hand_fingers(FingerID)
);

CREATE TABLE jop_titles(
	JopTitleID INT NOT NULL,
    JopTitleAR VARCHAR(100) NOT NULL,
    JopTitleEN VARCHAR(100) NOT NULL,
    PRIMARY KEY (JopTitleID)
);

CREATE TABLE emp_jop_titles(
	EmpID INT NOT NULL,
    JopTitleID INT NOT NULL,
    FOREIGN KEY (EmpID) REFERENCES emp_employees(EmpID),
    FOREIGN KEY (JopTitleID) REFERENCES jop_titles(JopTitleID)
);

CREATE TABLE emp_history_login(
	EmpID INT NOT NULL,
    DateOfLoging DATETIME NOT NULL,
    SourceIP VARCHAR (24),
    FOREIGN KEY (EmpID) REFERENCES emp_employees(EmpID)
);

CREATE TABLE emp_history_commands(
	EmpID INT NOT NULL,
    Command VARCHAR(100) NOT NULL,
    RunTime DATETIME,
    FOREIGN KEY (EmpID) REFERENCES emp_employees(EmpID)
);

CREATE TABLE emp_attendance(
	EmpID INT NOT NULL,
    DateOfAttending DATETIME,
    FOREIGN KEY (EmpID) REFERENCES emp_employees(EmpID)
);

CREATE TABLE suppliers(
	SupplierID INT NOT NULL AUTO_INCREMENT,
	supplierNameEN VARCHAR(50) NOT NULL,
    supplierNameAR VARCHAR(50),
    supplierVatNumber VARCHAR(24),
    Discrption VARCHAR (600),
    PRIMARY KEY (SupplierID)
);

CREATE TABLE suppliers_email_addresses(
	SupplierID INT NOT NULL,
    EmailAddress VARCHAR(150) NOT NULL,
    FOREIGN KEY (SupplierID) REFERENCES suppliers(SupplierID),
    UNIQUE (EmailAddress)
);

CREATE TABLE suppliers_contact_numbers(
	SupplierID INT NOT NULL,
    CountryID INT NOT NULL,
    ContactTypeID INT NOT NULL,
    ContactNumber VARCHAR(10) NOT NULL,
    FOREIGN KEY (CountryID) REFERENCES countries(CountryID),
    FOREIGN KEY (SupplierID) REFERENCES suppliers(SupplierID),
    FOREIGN KEY (ContactTypeID) REFERENCES contact_type(ContactTypeID),
    UNIQUE (ContactNumber)
);

CREATE TABLE suppliers_bank_accounts(
	SupplierID INT NOT NULL,
    BankNameAR VARCHAR(100),
    BankNameEN VARCHAR(100),
    BankIban VARCHAR(24),
    FullNameOnwer VARCHAR(100),
    ExpiryDate DATE,
    FOREIGN KEY (SupplierID) REFERENCES suppliers(SupplierID)
);

CREATE TABLE products(
	ProductID INT NOT NULL AUTO_INCREMENT,
    SupplierID INT NOT NULL,
    ProductGroubID INT NOT NULL,
    ProductTypeID INT NOT NULL,
	ProductNameEn VARCHAR(100) NOT NULL,
    ProductNameAr VARCHAR(100),
    CostPrice FLOAT NOT NULL,
    Price FLOAT NOT NULL,
    ProfitMargin FLOAT NOT NULL,
    UnitValueID INT,
    CurrencyID INT NOT NULL,
    DateOfProduction DATE NOT NULL,
    ExpiryDate DATE NOT NULL,
    Barcode INT,
    IncludeVat BOOLEAN DEFAULT TRUE,
    IncludePrescription BOOLEAN DEFAULT FALSE,
    UPC NCHAR(20),
    SKU NCHAR(20),
    ISBN NCHAR(20),
    Available BOOLEAN DEFAULT TRUE,
    PRIMARY KEY (ProductID),
    FOREIGN KEY (SupplierID) REFERENCES suppliers(SupplierID),
    FOREIGN KEY (ProductGroubID) REFERENCES products_groub(ProductGroubID),
    FOREIGN KEY (ProductGroubID) REFERENCES products_groub(ProductGroubID),
	FOREIGN KEY (UnitValueID) REFERENCES products_units_value(UnitValueID),
    FOREIGN KEY (CurrencyID) REFERENCES currencies(CurrencyID)
);

CREATE TABLE products_stock(
    ProductID INT,
    Discrption VARCHAR (600),
	Size INT NOT NULL,
    UnitValueID INT NOT NULL,
	Quantity INT NOT NULL,
	FOREIGN KEY (ProductID) REFERENCES products(ProductID)
);

CREATE TABLE invoices(
	InvoiceID INT NOT NULL AUTO_INCREMENT,
    InvoiceTypeID INT NOT NULL,
    PaymentMethodID INT NOT NULL,
    PaymentMechanismeID INT NOT NULL,
    EmpID INT NOT NULL,
    InvoiceDate DATE NOT NULL,
    Discount FLOAT NOT NULL,
    VAT FLOAT NOT NULL,
    Total FLOAT NOT NULL,
	Paid FLOAT NOT NULL,
    Credit FLOAT NOT NULL,
    Remain FLOAT NOT NULL,
    CurrencyID INT,
    Barcode INT NOT NULL,
    Discrption VARCHAR (600),
    PRIMARY KEY (InvoiceID),
    FOREIGN KEY (InvoiceTypeID) REFERENCES invoice_type(InvoiceTypeID),
    FOREIGN KEY (PaymentMethodID) REFERENCES payment_methods(PaymentMethodID),
    FOREIGN KEY (PaymentMechanismeID) REFERENCES payment_mechanisms(PaymentMechanismeID),
    FOREIGN KEY (EmpID) REFERENCES emp_employees(EmpID),
    FOREIGN KEY (CurrencyID) REFERENCES currencies(CurrencyID)
);

CREATE TABLE sales(
	InvoiceID INT NOT NULL,
	ProductGroubID INT,
    ProductID INT,
    Price FLOAT NOT NULL,
    Size INT,
    UnitsValueID INT,
    Quantity INT,
    Discrption VARCHAR (600),
    FOREIGN KEY (InvoiceID) REFERENCES invoices(InvoiceID),
    FOREIGN KEY (ProductGroubID) REFERENCES products_groub(ProductGroubID),
    FOREIGN KEY (ProductID) REFERENCES products(ProductID)
);

CREATE TABLE sales_returns(
    InvoiceID INT NOT NULL,
	ProductID INT,
    Price FLOAT NOT NULL,
    Size INT,
    UnitsValueID INT,
    Quantity INT,
    FOREIGN KEY (InvoiceID) REFERENCES invoices(InvoiceID),
    FOREIGN KEY (ProductID) REFERENCES products(ProductID)
);

CREATE TABLE purchases(
    InvoiceID INT NOT NULL,
    SupplierID INT,
	ProductID INT,
    Price FLOAT NOT NULL,
    Size INT,
    UnitsValueID INT,
    Quantity INT,
    Discrption VARCHAR (600),
    InvoiceSupplierID VARCHAR(100) NOT NULL,
    InvoiceSupplierDate DATE NOT NULL,
    FOREIGN KEY (InvoiceID) REFERENCES invoices(InvoiceID),
    FOREIGN KEY (SupplierID) REFERENCES suppliers(SupplierID),
    FOREIGN KEY (ProductID) REFERENCES products(ProductID)
);



CREATE TABLE purchases_returns(
    InvoiceID INT NOT NULL,
	ProductID INT,
    Price FLOAT NOT NULL,
    Size INT,
    UnitsValueID INT,
    Quantity INT,
    FOREIGN KEY (InvoiceID) REFERENCES invoices(InvoiceID),
    FOREIGN KEY (ProductID) REFERENCES products(ProductID)
);

CREATE TABLE suppliers_financial_history(
	InvoiceID INT,
    SupplierID INT,
    InvoiceTypeID INT,
    FOREIGN KEY (InvoiceTypeID) REFERENCES invoice_type(InvoiceTypeID),
    FOREIGN KEY (InvoiceID) REFERENCES invoices(InvoiceID),
    FOREIGN KEY (SupplierID) REFERENCES suppliers(SupplierID)
);

CREATE TABLE products_history(
    ProductID INT,
    InvoiceID INT,
    InvoiceTypeID INT,
	FOREIGN KEY (ProductID) REFERENCES products(ProductID),
	FOREIGN KEY (InvoiceID) REFERENCES invoices(InvoiceID),
	FOREIGN KEY (InvoiceTypeID) REFERENCES invoice_type(InvoiceTypeID)
);


CREATE TABLE customer_groups(
	CustomerGroupID INT NOT NULL AUTO_INCREMENT,
    CustomerGroupNameEN VARCHAR(50) NOT NULL,
    CustomerGroupNameAR VARCHAR(50),
    PRIMARY KEY (CustomerGroupID)
);

CREATE TABLE customers(
	CustomerID INT NOT NULL AUTO_INCREMENT,
	CustomerGroupID INT,
    UserName VARCHAR(50),
	CustomerNameEN VARCHAR(50) NOT NULL,
    CustomerNameAR VARCHAR(50),
	DateOfBirh DATE,
    CustomerNationalNumber INT,
    Password VARCHAR(25) NOT NULL,
    PRIMARY KEY (CustomerID),
    FOREIGN KEY (CustomerGroupID) REFERENCES customer_groups(CustomerGroupID),
    UNIQUE (UserName)
);

CREATE TABLE customer_email_addresses(
	CustomerID INT NOT NULL,
    EmailAddress VARCHAR(150) NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES customers(CustomerID),
    UNIQUE (EmailAddress)
);

CREATE TABLE customer_contact_numbers(
	CustomerID INT NOT NULL,
    CountryID INT NOT NULL,
    ContactTypeID INT NOT NULL,
    ContactNumber VARCHAR(10) NOT NULL,
    FOREIGN KEY (countryID) REFERENCES countries(countryID),
    FOREIGN KEY (CustomerID) REFERENCES customers(CustomerID),
    FOREIGN KEY (ContactTypeID) REFERENCES contact_type(ContactTypeID),
    UNIQUE (ContactNumber)
);

CREATE TABLE customer_bank_accounts(
	CustomerID INT NOT NULL,
    BankNameAR VARCHAR(100) NOT NULL,
    BankNameEN VARCHAR(100) NOT NULL,
    BankIban VARCHAR(24) NOT NULL,
    BankCardOnwer VARCHAR(100) NOT NULL,
    ExpiryDate DATE NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES customers(CustomerID)
);

CREATE TABLE customer_fingerprints(
	CustomerID INT NOT NULL,
    HandID INT,
    FingerID INT,
    FingerPrint BLOB NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES customers(CustomerID),
    FOREIGN KEY (HandID) REFERENCES hands(HandID),
    FOREIGN KEY (FingerID) REFERENCES hand_fingers(FingerID)
);

CREATE TABLE customer_Addresses(
	CustomerID INT NOT NULL,
    CountryID INT NOT NULL,
    District VARCHAR (45) NOT NULL,
    Street VARCHAR (45) NOT NULL,
    Description VARCHAR (100) NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES customers(CustomerID),
    FOREIGN KEY (CountryID) REFERENCES Countries(CountryID)
);

CREATE TABLE customer_wallet(
	CustomerID INT,
    Pints FLOAT,
    Cash FLOAT,
    PointsTakenDate DATE NOT NULL,
    PointsExpiryDate DATE NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES customers(CustomerID),
    UNIQUE (CustomerID)
);

CREATE TABLE customer_financial_history(
	InvoiceID INT,
    CustomerID INT,
    InvoiceTypeID INT,
    FOREIGN KEY (InvoiceTypeID) REFERENCES invoice_type(InvoiceTypeID),
    FOREIGN KEY (InvoiceID) REFERENCES invoices(InvoiceID),
    FOREIGN KEY (CustomerID) REFERENCES customers(CustomerID)
);

CREATE TABLE customer_login_history(
    CustomerID INT,
    SourceIP VARCHAR (24),
    DateOfLoging DATE,
    FOREIGN KEY (CustomerID) REFERENCES customers(CustomerID)
);