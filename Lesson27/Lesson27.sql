IF (NOT EXISTS(SELECT*
				FROM INFORMATION_SCHEMA.TABLES
				WHERE TABLE_SCHEMA = 'dbo'
				AND TABLE_NAME = 'Phonebook'))
BEGIN 
	CREATE TABLE Beetroot.dbo.Phonebook
	(
		Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		FirstName varchar(100) NOT NULL,
		LastName varchar(100) NOT NULL,
		PhoneNumber varchar(13) NOT NULL,
		Adress text DEFAULT '',
		Image varbinary(max),
		CONSTRAINT UC_PhoneNumber UNIQUE (PhoneNumber)
	)
END


