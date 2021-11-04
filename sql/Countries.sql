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
