CREATE TABLE continents(
	ContinentID INT NOT NULL AUTO_INCREMENT,
    ContinentNameEN NVARCHAr(50) NOT NULL,
    ContinentNameAR NVARCHAr(50) NOT NULL,
    PRIMARY KEY (ContinentID)
);

CREATE TABLE countries(
	CountryID INT NOT NULL AUTO_INCREMENT,
    ContinentID INT NOT NULL,
    CountryCallingCodeID INT NOT NULL,
    CountryNameEN NVARCHAr(50) NOT NULL,
    CountryNameAR NVARCHAr(50) NOT NULL,
    PRIMARY KEY (CountryID),
    FOREIGN KEY (ContinentID) REFERENCES Continents(ContinentID),
    UNIQUE (CountryCallingCodeID)
);

CREATE TABLE contact_type(
	ContactTypeID INT AUTO_INCREMENT,
	ContactNameEN NVARCHAR(50) NOT NULL,
	ContactNameAR NVARCHAR(50) NOT NULL,
	PRIMARY KEY (ContactTypeID)
);

CREATE TABLE hands(
	HandID INT AUTO_INCREMENT,
	HandNameEN NVARCHAR(50) NOT NULL,
	HandNameAR NVARCHAR(50) NOT NULL,
	PRIMARY KEY (HandID)
);

CREATE TABLE hand_fingers(
	FingerID INT AUTO_INCREMENT,
	HandID INT,
	FingerNameEN NVARCHAR(50) NOT NULL,
	FingerNameAR NVARCHAR(50) NOT NULL,
	PRIMARY KEY (FingerID),
    FOREIGN KEY (HandID) REFERENCES hands(HandID),
);

CREATE TABLE currencies(
	CurrencyID INT NOT NULL AUTO_INCREMENT,
    CountryCurrency NVARCHAR(30) NOT NULL,
    CurrencyShortCut NCHAR(5) NOT NULL,
    PRIMARY KEY (CurrencyID)
);

CREATE TABLE invoice_type(
	InvoiceTypeID INT NOT NULL AUTO_INCREMENT,
    InvoiceTypeNameEN NVARCHAr(50) NOT NULL,
    InvoiceTypeNameAR NVARCHAr(50) NOT NULL,
    PRIMARY KEY (InvoiceTypeID)
);

CREATE TABLE payment_methods(
	PaymentMethodID int NOT NULL AUTO_INCREMENT,
    PaymentMethodNameEN NVARCHAr(50) NOT NULL,
    PaymentMethodNameAR NVARCHAr(50) NOT NULL,
    PRIMARY KEY (PaymentMethodID)
);

CREATE TABLE payment_mechanisms(
	PaymentMechanismeID INT NOT NULL AUTO_INCREMENT,
    PaymentMechanismeNameEN NVARCHAr(50) NOT NULL,
    PaymentMechanismeNameAR NVARCHAr(50) NOT NULL,
    PRIMARY KEY (PaymentMechanismeID)
);