

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
    Discrption NVARCHAR (MAX),
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
    Discrption NVARCHAR (MAX),
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
    Discrption NVARCHAR (600),
    InvoiceSupplierID NVARCHAR(100) NOT NULL,
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

