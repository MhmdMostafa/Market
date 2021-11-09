CREATE TABLE suppliers(
	SupplierID INT NOT NULL AUTO_INCREMENT,
	supplierNameEN NVARCHAR(50) NOT NULL,
    supplierNameAR NVARCHAR(50),
    supplierVatNumber NVARCHAR(24),
    Discrption NVARCHAR (MAX)
    PRIMARY KEY (SupplierID)
);

CREATE TABLE suppliers_email_addresses(
	SupplierID INT NOT NULL,
    EmailAddress NVARCHAR(150) NOT NULL,
    FOREIGN KEY (SupplierID) REFERENCES suppliers(SupplierID),
    UNIQUE (EmailAddress)
);

CREATE TABLE suppliers_contact_numbers(
	SupplierID INT NOT NULL,
    CountryID INT NOT NULL,
    ContactTypeID INT NOT NULL,
    ContactNumber NVARCHAR(10) NOT NULL,
    FOREIGN KEY (CountryID) REFERENCES countries(CountryID),
    FOREIGN KEY (SupplierID) REFERENCES suppliers(SupplierID),
    FOREIGN KEY (ContactTypeID) REFERENCES contact_type(ContactTypeID),
    UNIQUE (ContactNumber)
);

CREATE TABLE suppliers_bank_accounts(
	SupplierID INT NOT NULL,
    BankNameAR NVARCHAR(100),
    BankNameEN NVARCHAR(100),
    BankIban NVARCHAR(24),
    FullNameOnwer NVARCHAR(100),
    ExpiryDate DATE,
    FOREIGN KEY (SupplierID) REFERENCES suppliers(SupplierID)
);

CREATE TABLE suppliers_financial_history(
	InvoiceID INT,
    SupplierID INT,
    InvoiceTypeID INT,
    FOREIGN KEY (InvoiceTypeID) REFERENCES invoice_type(InvoiceTypeID),
    FOREIGN KEY (InvoiceID) REFERENCES invocies(InvoiceID),
    FOREIGN KEY (SupplierID) REFERENCES suppliers(SupplierID)
);