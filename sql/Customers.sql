CREATE TABLE customer_groups(
	CustomerGroupID INT NOT NULL AUTO_INCREMENT,
    CustomerGroupNameEN NVARCHAR(50) NOT NULL,
    CustomerGroupNameAR NVARCHAR(50),
    PRIMARY KEY (CustomerGroupID)
);

CREATE TABLE customers(
	CustomerID INT NOT NULL AUTO_INCREMENT,
	CustomerGroupID INT,
    UserName NVARCHAR(50),
	CustomerNameEN NVARCHAR(50) NOT NULL,
    CustomerNameAR NVARCHAR(50),
	DateOfBirh DATE,
    CustomerNationalNumber INT,
    Password NVARCHAR(25) NOT NULL,
    PRIMARY KEY (CustomerID),
    FOREIGN KEY (CustomerGroupID) REFERENCES customer_groups(CustomerGroupID),
    UNIQUE (UserName)
);

CREATE TABLE customer_email_addresses(
	CustomerID INT NOT NULL,
    EmailAddress NVARCHAR(150) NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES customers(CustomerID),
    UNIQUE (EmailAddress)
);

CREATE TABLE customer_contact_numbers(
	CustomerID INT NOT NULL,
    CountryID INT NOT NULL,
    ContactTypeID INT NOT NULL,
    ContactNumber NVARCHAR(10) NOT NULL,
    FOREIGN KEY (countryID) REFERENCES countries(countryID),
    FOREIGN KEY (CustomerID) REFERENCES customers(CustomerID),
    FOREIGN KEY (ContactTypeID) REFERENCES contact_type(ContactTypeID),
    UNIQUE (ContactNumber)
);

CREATE TABLE customer_bank_accounts(
	CustomerID INT NOT NULL,
    BankNameAR NVARCHAR(100) NOT NULL,
    BankNameEN NVARCHAR(100) NOT NULL,
    BankIban NVARCHAR(24) NOT NULL,
    BankCardOnwer NVARCHAR(100) NOT NULL,
    ExpiryDate DATE NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES customers(CustomerID),
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
    District NVARCHAR (45) NOT NULL,
    Street NVARCHAR (45) NOT NULL,
    Description NVARCHAR (100) NOT NULL,
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
    FOREIGN KEY (InvoiceID) REFERENCES invocies(InvoiceID),
    FOREIGN KEY (CustomerID) REFERENCES customers(CustomerID)
);