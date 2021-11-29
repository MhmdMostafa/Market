CREATE DATABASE market DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci ;
USE market;

CREATE TABLE continents(
	ID INT NOT NULL AUTO_INCREMENT,
    NameEn VARCHAR(50) NOT NULL,
    NameAr VARCHAR(50) NOT NULL,
    PRIMARY KEY (ID)
);

CREATE TABLE countries(
	ID INT NOT NULL AUTO_INCREMENT,
    NameEn VARCHAR(50) NOT NULL,
    NameAr VARCHAR(50) NOT NULL,
    ContinentID INT NOT NULL,
    CallingCode VARCHAR (6) NOT NULL,
    Shortcut VARCHAR (10) NOT NULL,
    PRIMARY KEY (ID),
    FOREIGN KEY (ContinentID) REFERENCES Continents(ID),
    UNIQUE (CallingCode),
    UNIQUE (Shortcut)
);

CREATE TABLE cities(
    ID INT NOT NULL AUTO_INCREMENT,
	CountryID INT,
    NameEn VARCHAR(50) NOT NULL,
    NameAr VARCHAR(50) NOT NULL,
    PRIMARY KEY (ID),
    FOREIGN KEY (CountryID) REFERENCES countries(ID)
);

CREATE TABLE contact_type(
	ID INT AUTO_INCREMENT,
	NameEn VARCHAR(50) NOT NULL,
	NameAr VARCHAR(50) NOT NULL,
	PRIMARY KEY (ID)
);

CREATE TABLE nav_sections(
	ID INT AUTO_INCREMENT,
    SectionID INT,
	NameEn VARCHAR(50) NOT NULL,
	NameAr VARCHAR(50) NOT NULL,
	PRIMARY KEY (ID),
    FOREIGN KEY (SectionID) REFERENCES nav_sections(ID)
);


CREATE TABLE nav_rows(
	ID INT AUTO_INCREMENT,
    SectionID INT,
	NameEn VARCHAR(50) NOT NULL,
	NameAr VARCHAR(50) NOT NULL,
	PRIMARY KEY (ID),
    FOREIGN KEY (SectionID) REFERENCES nav_sections(ID)
);

CREATE TABLE nav_columns(
	ID INT AUTO_INCREMENT,
    SectionID INT,
	NameEn VARCHAR(50) NOT NULL,
	NameAr VARCHAR(50) NOT NULL,
	PRIMARY KEY (ID),
    FOREIGN KEY (SectionID) REFERENCES nav_sections(ID)
);

CREATE TABLE hands(
	ID INT AUTO_INCREMENT,
	NameEn VARCHAR(50) NOT NULL,
	NameAr VARCHAR(50) NOT NULL,
	PRIMARY KEY (ID)
);

CREATE TABLE hand_fingers(
	ID INT AUTO_INCREMENT,
	HandID INT,
	NameEn VARCHAR(50) NOT NULL,
	NameAr VARCHAR(50) NOT NULL,
	PRIMARY KEY (ID),
    FOREIGN KEY (HandID) REFERENCES hands(ID)
);

CREATE TABLE gender(
    ID INT NOT NULL AUTO_INCREMENT,
    NameEn VARCHAR(100) NOT NULL,
    NameAr VARCHAR(100) NOT NULL,
    Shortcut CHAR(6) NOT NULL,
    PRIMARY KEY (ID)
);

CREATE TABLE currencies(
	ID INT NOT NULL AUTO_INCREMENT,
    NameEn VARCHAR(100) NOT NULL,
    NameAr VARCHAR(100) NOT NULL,
    Shortcut CHAR(6) NOT NULL,
    PRIMARY KEY (ID),
    UNIQUE(Shortcut)
);

CREATE TABLE invoice_type(
	ID INT NOT NULL AUTO_INCREMENT,
    NameEn VARCHAR(50) NOT NULL,
    NameAr VARCHAR(50) NOT NULL,
    PRIMARY KEY (ID)
);

CREATE TABLE payment_mechanisms(
	ID INT NOT NULL AUTO_INCREMENT,
    NameEn VARCHAR(50) NOT NULL,
    NameAr VARCHAR(50) NOT NULL,
    PRIMARY KEY (ID)
);

CREATE TABLE payment_methods(
	ID int NOT NULL AUTO_INCREMENT,
    NameEn VARCHAR(50) NOT NULL,
    NameAr VARCHAR(50) NOT NULL,
    PRIMARY KEY (ID)
);

CREATE TABLE units_value(
	ID INT NOT NULL AUTO_INCREMENT,
	NameEn VARCHAR(50) NOT NULL,
    NameAr VARCHAR(50) NOT NULL,
	Shortcut VARCHAR(10) NOT NULL,
    PRIMARY KEY (ID),
    UNIQUE(Shortcut)
);
-- grobe like asprin or else
CREATE TABLE products_groub(
	ID INT NOT NULL AUTO_INCREMENT,
	NameEn VARCHAR(50) NOT NULL,
	NameAr VARCHAR(50) NOT NULL,
    PRIMARY KEY (ID)
);

CREATE TABLE products_type(
	ID INT NOT NULL AUTO_INCREMENT,
	NameEn VARCHAR(50) NOT NULL,
	NameAr VARCHAR(50) NOT NULL,
    PRIMARY KEY (ID)
);

CREATE TABLE our_warehouses(
    ID INT NOT NULL AUTO_INCREMENT,
    NameEn VARCHAR(100),
    NameAr VARCHAR(100),
    PRIMARY KEY (ID)
);

CREATE TABLE our_warehouses_addresses(
    ID INT NOT NULL AUTO_INCREMENT,
	UserID INT NOT NULL,
    CountryID INT NOT NULL,
    CityID INT NOT NULL,
    District VARCHAR (45) NOT NULL,
    Street VARCHAR (45) NOT NULL,
    ZipCode INT,
    Description VARCHAR (100) NOT NULL,
    PRIMARY KEY (ID),
    FOREIGN KEY (UserID) REFERENCES our_warehouses(ID),
    FOREIGN KEY (CountryID) REFERENCES Countries(ID),
    FOREIGN KEY (CityID) REFERENCES cities(ID)
);

CREATE TABLE our_warehouses_numbers(
    ID INT NOT NULL AUTO_INCREMENT,
	UserID INT NOT NULL,
    CountryID INT NOT NULL,
    ContactTypeID INT NOT NULL,
    ContactNumber VARCHAR(10) NOT NULL,
    PRIMARY KEY(ID),
    FOREIGN KEY (UserID) REFERENCES our_warehouses(ID),
    FOREIGN KEY (CountryID) REFERENCES countries(ID),
    FOREIGN KEY (ContactTypeID) REFERENCES contact_type(ID),
    UNIQUE (ContactNumber)
);

CREATE TABLE emp_group(
	ID INT NOT NULL AUTO_INCREMENT,
    NameEn VARCHAR(50) NOT NULL,
    NameAr VARCHAR(50),
    PRIMARY KEY (ID)
);

CREATE TABLE emp_permissions(
	ID INT NOT NULL AUTO_INCREMENT,
    NameEn VARCHAR(50) NOT NULL,
    NameAr VARCHAR(50),
    PRIMARY KEY (ID)
);

CREATE TABLE emp_group_permissions(
    ID INT NOT NULL AUTO_INCREMENT,
    NameEn VARCHAR(50) NOT NULL,
    NameAr VARCHAR(50),
	EmpGroupID INT,
    PermissionID INT,
    PermissionState BOOLEAN DEFAULT FALSE,
    PRIMARY KEY (ID),
    FOREIGN KEY (EmpGroupID) REFERENCES emp_group(ID),
    FOREIGN KEY (PermissionID) REFERENCES emp_permissions(ID)
);

CREATE TABLE employees(
	ID INT NOT NULL AUTO_INCREMENT,
	EmpGroupID INT,
    UserName VARCHAR(50) NOT NULL,
	NameEn VARCHAR(50),
    NameAr VARCHAR(50),
	DateOfBirh DATE,
    Pass_word VARCHAR(255) NOT NULL,
    GenderID INT,
    PRIMARY KEY (ID),
    FOREIGN KEY (EmpGroupID) REFERENCES emp_group(ID),
    FOREIGN KEY (GenderID) REFERENCES gender(ID),
    UNIQUE (UserName)
);

CREATE TABLE emp_email_addresses(
    ID INT NOT NULL AUTO_INCREMENT,
	UserID INT NOT NULL,
    EmailAddress VARCHAR(150) NOT NULL,
    PRIMARY KEY(ID),
    FOREIGN KEY (UserID) REFERENCES employees(ID),
    UNIQUE (EmailAddress)
);

CREATE TABLE emp_contact_numbers(
    ID INT NOT NULL AUTO_INCREMENT,
	UserID INT NOT NULL,
    CountryID INT NOT NULL,
    ContactTypeID INT NOT NULL,
    ContactNumber VARCHAR(10) NOT NULL,
    PRIMARY KEY(ID),
    FOREIGN KEY (UserID) REFERENCES employees(ID),
    FOREIGN KEY (CountryID) REFERENCES countries(ID),
    FOREIGN KEY (ContactTypeID) REFERENCES contact_type(ID),
    UNIQUE (ContactNumber)
);

CREATE TABLE emp_bank_accounts(
    ID INT NOT NULL AUTO_INCREMENT,
	UserID INT NOT NULL,
    NameEn VARCHAR(100) NOT NULL,
    NameAr VARCHAR(100) NOT NULL,
    Iban VARCHAR(24) NOT NULL,
    FullNameOwner VARCHAR(100) NOT NULL,
    ExpiryDate DATE NOT NULL,
    PRIMARY KEY (ID),
    FOREIGN KEY (UserID) REFERENCES employees(ID),
    UNIQUE (Iban)
);

CREATE TABLE emp_addresses(
    ID INT NOT NULL AUTO_INCREMENT,
	UserID INT NOT NULL,
    CountryID INT NOT NULL,
    CityID INT NOT NULL,
    District VARCHAR (45) NOT NULL,
    Street VARCHAR (45) NOT NULL,
    ZipCode INT,
    Description VARCHAR (100) NOT NULL,
    PRIMARY KEY (ID),
    FOREIGN KEY (UserID) REFERENCES employees(ID),
    FOREIGN KEY (CountryID) REFERENCES Countries(ID),
    FOREIGN KEY (CityID) REFERENCES cities(ID)
);

CREATE TABLE emp_fingerprints(
	EmpID INT NOT NULL,
    HandID INT,
    FingerID INT,
    FingerPrint BLOB NOT NULL,
    FOREIGN KEY (EmpID) REFERENCES employees(ID),
    FOREIGN KEY (HandID) REFERENCES hands(ID),
    FOREIGN KEY (FingerID) REFERENCES hand_fingers(ID)
);

-- CREATE TABLE jop_titles(
-- 	JopTitleID INT NOT NULL,
--     JopTitleAR VARCHAR(100) NOT NULL,
--     JopTitleEN VARCHAR(100) NOT NULL,
--     PRIMARY KEY (JopTitleID)
-- );

-- CREATE TABLE emp_jop_titles(
-- 	EmpID INT NOT NULL,
--     JopTitleID INT NOT NULL,
--     FOREIGN KEY (EmpID) REFERENCES employees(EmpID),
--     FOREIGN KEY (JopTitleID) REFERENCES jop_titles(JopTitleID)
-- );

CREATE TABLE emp_history_login(
	EmpID INT NOT NULL,
    DateOfLoging DATETIME NOT NULL,
    SourceIP VARCHAR (24),
    FOREIGN KEY (EmpID) REFERENCES employees(ID)
);

CREATE TABLE emp_history_commands(
	EmpID INT NOT NULL,
    Command VARCHAR(100) NOT NULL,
    RunTime DATETIME,
    FOREIGN KEY (EmpID) REFERENCES employees(ID)
);

CREATE TABLE emp_attendance(
	EmpID INT NOT NULL,
    DateOfAttending DATETIME,
    FOREIGN KEY (EmpID) REFERENCES employees(ID)
);

CREATE TABLE suppliers(
	ID INT NOT NULL AUTO_INCREMENT,
	NameEn VARCHAR(50) NOT NULL,
    NameAr VARCHAR(50),
    VatNumber VARCHAR(24),
    Description VARCHAR (600),
    PRIMARY KEY (ID)
);

CREATE TABLE suppliers_email_addresses(
    ID INT NOT NULL AUTO_INCREMENT,
	UserID INT NOT NULL,
    EmailAddress VARCHAR(150) NOT NULL,
    PRIMARY KEY(ID),
    FOREIGN KEY (UserID) REFERENCES suppliers(ID),
    UNIQUE (EmailAddress)
);

CREATE TABLE suppliers_contact_numbers(
    ID INT NOT NULL AUTO_INCREMENT,
	UserID INT NOT NULL,
    CountryID INT NOT NULL,
    ContactTypeID INT NOT NULL,
    ContactNumber VARCHAR(10) NOT NULL,
    PRIMARY KEY(ID),
    FOREIGN KEY (CountryID) REFERENCES countries(ID),
    FOREIGN KEY (UserID) REFERENCES suppliers(ID),
    FOREIGN KEY (ContactTypeID) REFERENCES contact_type(ID),
    UNIQUE (ContactNumber)
);

CREATE TABLE suppliers_bank_accounts(
    ID INT NOT NULL AUTO_INCREMENT,
	UserID INT NOT NULL,
    NameEn VARCHAR(100),
    NameAr VARCHAR(100),
    Iban VARCHAR(24),
    FullNameOwner VARCHAR(100),
    ExpiryDate DATE,
    PRIMARY KEY (ID),
    FOREIGN KEY (UserID) REFERENCES suppliers(ID),
    UNIQUE (Iban)
);

CREATE TABLE suppliers_warehouses(
    ID INT NOT NULL AUTO_INCREMENT,
	UserID INT NOT NULL,
    NameEn VARCHAR(100),
    NameAr VARCHAR(100),
    PRIMARY KEY (ID),
    FOREIGN KEY (UserID) REFERENCES suppliers(ID)
);

CREATE TABLE suppliers_warehouses_addresses(
    ID INT NOT NULL AUTO_INCREMENT,
	UserID INT NOT NULL,
    CountryID INT NOT NULL,
    CityID INT NOT NULL,
    District VARCHAR (45) NOT NULL,
    Street VARCHAR (45) NOT NULL,
    ZipCode INT,
    Description VARCHAR (100) NOT NULL,
    PRIMARY KEY (ID),
    FOREIGN KEY (UserID) REFERENCES suppliers_warehouses(ID),
    FOREIGN KEY (CountryID) REFERENCES Countries(ID),
    FOREIGN KEY (CityID) REFERENCES cities(ID)
);

CREATE TABLE suppliers_warehouses_numbers(
    ID INT NOT NULL AUTO_INCREMENT,
	UserID INT NOT NULL,
    CountryID INT NOT NULL,
    ContactTypeID INT NOT NULL,
    ContactNumber VARCHAR(10) NOT NULL,
    PRIMARY KEY(ID),
    FOREIGN KEY (UserID) REFERENCES suppliers_warehouses(ID),
    FOREIGN KEY (CountryID) REFERENCES countries(ID),
    FOREIGN KEY (ContactTypeID) REFERENCES contact_type(ID),
    UNIQUE (ContactNumber)
);

CREATE TABLE products(
	ID INT NOT NULL AUTO_INCREMENT,
    ProductGroubID INT NOT NULL,
    ProductTypeID INT NOT NULL,
	NameEn VARCHAR(100) NOT NULL,
    NameAr VARCHAR(100),
    Size INT NOT NULL,
    UnitValueID INT NOT NULL,
    Price FLOAT NOT NULL,
    CurrencyID INT NOT NULL,
    Barcode VARCHAR(100),
    IncludeVat BOOLEAN DEFAULT TRUE,
    IncludePrescription BOOLEAN DEFAULT FALSE,
    UPC CHAR(20),
    SKU CHAR(20),
    ISBN CHAR(20),
    PRIMARY KEY (ID),
    FOREIGN KEY (ProductGroubID) REFERENCES products_groub(ID),
    FOREIGN KEY (ProductTypeID) REFERENCES products_type(ID),
	FOREIGN KEY (UnitValueID) REFERENCES units_value(ID),
    FOREIGN KEY (CurrencyID) REFERENCES currencies(ID)
);

CREATE TABLE product_location(
    ID INT NOT NULL AUTO_INCREMENT,
    SectionID INT,
    RowID INT,
    ColumnID INT,
    PRIMARY KEY (ID),
    FOREIGN KEY (SectionID) REFERENCES nav_sections(ID),
    FOREIGN KEY (RowID) REFERENCES nav_rows(ID),
    FOREIGN KEY (ColumnID) REFERENCES nav_columns(ID)
);

CREATE TABLE products_stock(
    ID INT NOT NULL AUTO_INCREMENT,
    ProductID INT,
    SupplierID INT NOT NULL,
    WerehouseID INT,
    LocationID INT,
    CostPrice FLOAT NOT NULL,
    CurrencyID INT NOT NULL,
    Description VARCHAR (600),
	Quantity INT NOT NULL,
    Available BOOLEAN DEFAULT TRUE,
    DateOfProduction DATE NOT NULL,
    ExpiryDate DATE NOT NULL,
    Barcode VARCHAR(100),
    PRIMARY KEY (ID),
	FOREIGN KEY (ProductID) REFERENCES products(ID),
    FOREIGN KEY (SupplierID) REFERENCES suppliers(ID),
    FOREIGN KEY (WerehouseID) REFERENCES our_warehouses(ID),
    FOREIGN KEY (LocationID) REFERENCES product_location(ID),
    FOREIGN KEY (CurrencyID) REFERENCES currencies(ID)
);

CREATE TABLE invoices(
	ID INT NOT NULL AUTO_INCREMENT,
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
    Barcode VARCHAR(255),
    Description VARCHAR (600),
    PRIMARY KEY (ID),
    FOREIGN KEY (InvoiceTypeID) REFERENCES invoice_type(ID),
    FOREIGN KEY (PaymentMethodID) REFERENCES payment_methods(ID),
    FOREIGN KEY (PaymentMechanismeID) REFERENCES payment_mechanisms(ID),
    FOREIGN KEY (EmpID) REFERENCES employees(ID),
    FOREIGN KEY (CurrencyID) REFERENCES currencies(ID)
);

CREATE TABLE sales(
	InvoiceID INT NOT NULL,
	ProductGroubID INT,
    ProductID INT,
    Price FLOAT NOT NULL,
    Size INT,
    UnitValueID INT,
    Quantity INT,
    Description VARCHAR (600),
    FOREIGN KEY (InvoiceID) REFERENCES invoices(ID),
    FOREIGN KEY (ProductGroubID) REFERENCES products_groub(ID),
    FOREIGN KEY (UnitValueID) REFERENCES units_value(ID),
    FOREIGN KEY (ProductID) REFERENCES products(ID)
);

CREATE TABLE sales_returns(
    InvoiceID INT NOT NULL,
	ProductID INT,
    Price FLOAT NOT NULL,
    Size INT,
    UnitValueID INT,
    Quantity INT,
    FOREIGN KEY (InvoiceID) REFERENCES invoices(ID),
    FOREIGN KEY (ProductID) REFERENCES products(ID),
    FOREIGN KEY (UnitValueID) REFERENCES units_value(ID)
);

CREATE TABLE purchases(
    InvoiceID INT NOT NULL,
    SupplierID INT,
	ProductID INT,
    Price FLOAT NOT NULL,
    Size INT,
    UnitValueID INT,
    Quantity INT,
    Description VARCHAR (600),
    InvoiceSupplierID VARCHAR(100) NOT NULL,
    InvoiceSupplierDate DATE NOT NULL,
    FOREIGN KEY (InvoiceID) REFERENCES invoices(ID),
    FOREIGN KEY (SupplierID) REFERENCES suppliers(ID),
    FOREIGN KEY (ProductID) REFERENCES products(ID),
    FOREIGN KEY (UnitValueID) REFERENCES units_value(ID)
);



CREATE TABLE purchases_returns(
    InvoiceID INT NOT NULL,
	ProductID INT,
    Price FLOAT NOT NULL,
    Size INT,
    UnitValueID INT,
    Quantity INT,
    FOREIGN KEY (InvoiceID) REFERENCES invoices(ID),
    FOREIGN KEY (ProductID) REFERENCES products(ID),
    FOREIGN KEY (UnitValueID) REFERENCES units_value(ID)
);

CREATE TABLE suppliers_financial_history(
	InvoiceID INT,
    SupplierID INT,
    InvoiceTypeID INT,
    FOREIGN KEY (InvoiceTypeID) REFERENCES invoice_type(ID),
    FOREIGN KEY (InvoiceID) REFERENCES invoices(ID),
    FOREIGN KEY (SupplierID) REFERENCES suppliers(ID)
);

CREATE TABLE products_history(
    ProductID INT,
    InvoiceID INT,
    InvoiceTypeID INT,
	FOREIGN KEY (ProductID) REFERENCES products(ID),
	FOREIGN KEY (InvoiceID) REFERENCES invoices(ID),
	FOREIGN KEY (InvoiceTypeID) REFERENCES invoice_type(ID)
);


CREATE TABLE customer_groups(
	ID INT NOT NULL AUTO_INCREMENT,
    NameEn VARCHAR(50) NOT NULL,
    NameAr VARCHAR(50),
    PRIMARY KEY (ID)
);

CREATE TABLE customers(
	ID INT NOT NULL AUTO_INCREMENT,
	CustomerGroupID INT,
    UserName VARCHAR(50),
	NameEn VARCHAR(50) NOT NULL,
    NameAr VARCHAR(50),
	DateOfBirh DATE,
    NationalNumber VARCHAR(12),
    Pass_word VARCHAR(255),
    GenderID INT,
    PRIMARY KEY (ID),
    FOREIGN KEY (CustomerGroupID) REFERENCES customer_groups(ID),
    FOREIGN KEY (GenderID) REFERENCES gender(ID),
    UNIQUE (UserName)
);

CREATE TABLE customer_email_addresses(
    ID INT NOT NULL AUTO_INCREMENT,
	UserID INT NOT NULL,
    EmailAddress VARCHAR(150) NOT NULL,
    PRIMARY KEY(ID),
    FOREIGN KEY (UserID) REFERENCES customers(ID),
    UNIQUE (EmailAddress)
);

CREATE TABLE customer_contact_numbers(
    ID INT NOT NULL AUTO_INCREMENT,
	UserID INT NOT NULL,
    CountryID INT NOT NULL,
    ContactTypeID INT NOT NULL,
    ContactNumber VARCHAR(10) NOT NULL,
    PRIMARY KEY(ID),
    FOREIGN KEY (CountryID) REFERENCES countries(ID),
    FOREIGN KEY (UserID) REFERENCES customers(ID),
    FOREIGN KEY (ContactTypeID) REFERENCES contact_type(ID),
    UNIQUE (ContactNumber)
);

CREATE TABLE customer_bank_accounts(
    ID INT NOT NULL AUTO_INCREMENT,
	UserID INT NOT NULL,
    NameEn VARCHAR(100) NOT NULL,
    NameAr VARCHAR(100) NOT NULL,
    Iban VARCHAR(24) NOT NULL,
    FullNameOwner VARCHAR(100) NOT NULL,
    ExpiryDate DATE NOT NULL,
    PRIMARY KEY (ID),
    FOREIGN KEY (UserID) REFERENCES customers(ID),
    UNIQUE (Iban)
);

CREATE TABLE customer_fingerprints(
	CustomerID INT NOT NULL,
    HandID INT,
    FingerID INT,
    FingerPrint BLOB NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES customers(ID),
    FOREIGN KEY (HandID) REFERENCES hands(ID),
    FOREIGN KEY (FingerID) REFERENCES hand_fingers(ID)
);

CREATE TABLE customer_Addresses(
    ID INT NOT NULL AUTO_INCREMENT,
	UserID INT NOT NULL,
    CountryID INT NOT NULL,
    CityID INT NOT NULL,
    District VARCHAR (45) NOT NULL,
    Street VARCHAR (45) NOT NULL,
    ZipCode VARCHAR (12),
    Description VARCHAR (100) NOT NULL,
    PRIMARY KEY (ID),
    FOREIGN KEY (UserID) REFERENCES customers(ID),
    FOREIGN KEY (CountryID) REFERENCES Countries(ID),
    FOREIGN KEY (CityID) REFERENCES cities(ID)
);

CREATE TABLE customer_wallet(
	CustomerID INT,
    Pints FLOAT,
    Cash FLOAT,
    PointsTakenDate DATE NOT NULL,
    PointsExpiryDate DATE NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES customers(ID),
    UNIQUE (CustomerID)
);

CREATE TABLE customer_financial_history(
	InvoiceID INT,
    CustomerID INT,
    InvoiceTypeID INT,
    FOREIGN KEY (InvoiceTypeID) REFERENCES invoice_type(ID),
    FOREIGN KEY (InvoiceID) REFERENCES invoices(ID),
    FOREIGN KEY (CustomerID) REFERENCES customers(ID)
);

CREATE TABLE customer_login_history(
    CustomerID INT,
    SourceIP VARCHAR (24),
    DateOfLoging DATE,
    FOREIGN KEY (CustomerID) REFERENCES customers(ID)
);