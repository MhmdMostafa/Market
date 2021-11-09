CREATE TABLE products_units_value(
	UnitValueID INT NOT NULL AUTO_INCREMENT,
	UnitValueName NVARCHAR(30) NOT NULL,
	UnitsValueShortCut NVARCHAR(10) NOT NULL,
    PRIMARY KEY (UnitValueID)
);

CREATE TABLE products_groub(
	ProductGroubID INT NOT NULL AUTO_INCREMENT,
	ProductGroubNameEN NVARCHAR(50) NOT NULL,
	ProductGroubNameAR NVARCHAR(50) NOT NULL,
    PRIMARY KEY (ProductGroubID)
);

CREATE TABLE products_type(
	ProductTypeID INT NOT NULL AUTO_INCREMENT,
	ProductTypeNameEN NVARCHAR(50) NOT NULL,
	ProductTypeNameAR NVARCHAR(50) NOT NULL,
    PRIMARY KEY (ProductTypeID)
);

CREATE TABLE currencies(
	CurrencyID INT NOT NULL AUTO_INCREMENT,
    CountryCurrency NVARCHAR(30) NOT NULL,
    CurrencyShortCut NCHAR(5) NOT NULL,
    PRIMARY KEY (CurrencyID)
);

CREATE TABLE products(
	ProductID INT NOT NULL AUTO_INCREMENT,
    SupplierID INT NOT NULL,
    ProductGroubID INT NOT NULL,
    ProductTypeID INT NOT NULL,
	ProductNameEn NVARCHAR(100) NOT NULL,
    ProductNameAr NVARCHAR(100),
    CostPrice FLOAT NOT NULL,
    Price FLOAT NOT NULL,
    ProfitMargin FLOAT NOT NULL,
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
    Discrption NVARCHAR (MAX),
	Size INT NOT NULL,
    UnitValueID INT NOT NULL,
	Quantity INT NOT NULL,
	FOREIGN KEY (ProductID) REFERENCES products(ProductID)
);

CREATE TABLE products_history(
    ProductID INT,
    InvoiceID INT,
    InvoiceTypeID INT,
	FOREIGN KEY (ProductID) REFERENCES products(ProductID),
	FOREIGN KEY (InvoiceID) REFERENCES invocies(InvoiceID),
	FOREIGN KEY (InvoiceTypeID) REFERENCES invoice_type(InvoiceTypeID),
);