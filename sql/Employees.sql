CREATE TABLE emp_group(
	EmpGroupID INT NOT NULL AUTO_INCREMENT,
    EmpGroupNameEN NVARCHAR(50) NOT NULL,
    EmpGroupNameAR NVARCHAR(50),
    PRIMARY KEY (EmpGroupID)
);

CREATE TABLE emp_permissions(
	PermissionID INT NOT NULL AUTO_INCREMENT,
    PermissionNameEN NVARCHAR(50) NOT NULL,
    PermissionNameAr NVARCHAR(50) NOT NULL,
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
    UserName NVARCHAR(50),
	EmpNameEN NVARCHAR(50) NOT NULL,
    EmpNameAR NVARCHAR(50) ,
	DateOfBirh DATE,
    Password NVARCHAR(25) NOT NULL,
    PRIMARY KEY (EmpID),
    FOREIGN KEY (EmpGroupID) REFERENCES emp_group(EmpGroupID),
    UNIQUE (UserName)
);

CREATE TABLE emp_email_addresses(
	EmpID INT NOT NULL,
    EmailAddress NVARCHAR(150) NOT NULL,
    FOREIGN KEY (EmpID) REFERENCES emp_employees(EmpID),
    UNIQUE (EmailAddress)
);

CREATE TABLE emp_contact_numbers(
	EmpID INT NOT NULL,
    CountryID INT NOT NULL,
    ContactTypeID INT NOT NULL,
    ContactNumber NVARCHAR(10) NOT NULL,
    FOREIGN KEY (EmpID) REFERENCES emp_employees(EmpID),
    FOREIGN KEY (CountryID) REFERENCES countries(CountryID),
    FOREIGN KEY (ContactTypeID) REFERENCES contact_type(ContactTypeID),
    UNIQUE (ContactNumber)
);

CREATE TABLE emp_bank_accounts(
	EmpID INT NOT NULL,
    BankNameAR NVARCHAR(100) NOT NULL,
    BankNameEN NVARCHAR(100) NOT NULL,
    BankIban NVARCHAR(24) NOT NULL,
    FullNameOnwer NVARCHAR(100) NOT NULL,
    ExpiryDate DATE NOT NULL,
    FOREIGN KEY (EmpID) REFERENCES emp_employees(EmpID),
);

CREATE TABLE emp_Addresses(
	EmpID INT NOT NULL,
    CountryID INT NOT NULL,
    District NVARCHAR (45) NOT NULL,
    Street NVARCHAR (45) NOT NULL,
    Description NVARCHAR (100) NOT NULL,
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
    JopTitleAR NVARCHAR(100) NOT NULL,
    JopTitleEN NVARCHAR(100) NOT NULL,
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
    SourceIP NVARCHAR,
    FOREIGN KEY (EmpID) REFERENCES emp_employees(EmpID)
);

CREATE TABLE emp_history_commands(
	EmpID INT NOT NULL,
    Command NVARCHAR(100) NOT NULL,
    RunTime DATETIME,
    FOREIGN KEY (EmpID) REFERENCES emp_employees(EmpID)
);

CREATE TABLE emp_attendance(
	EmpID INT NOT NULL,
    DateOfAttending DATETIME,
    FOREIGN KEY (EmpID) REFERENCES emp_employees(EmpID)
);