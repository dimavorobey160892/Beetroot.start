
CREATE TABLE Beetroot.dbo.Author
	(
		Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		FirstName varchar(100) NOT NULL,
		LastName varchar(100) NOT NULL,
		Country varchar(100) NOT NULL,
		[Image] varbinary(max)
	)

CREATE TABLE Beetroot.dbo.Books
	(
		Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		Name varchar(100) NOT NULL,
		AuthorId int NOT NULL FOREIGN KEY REFERENCES dbo.Author(Id),
		CONSTRAINT UC_Name UNIQUE (Name, AuthorId)
	)

CREATE TABLE Beetroot.dbo.BooksCount
	(
		Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		[Count] int NOT NULL DEFAULT 0,
		BookId int NOT NULL FOREIGN KEY REFERENCES dbo.Books(Id)
	)

CREATE TABLE Beetroot.dbo.Customers
	(
		Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		FirstName varchar(100) NOT NULL,
		LastName varchar(100) NOT NULL,
		Adress varchar(100) NOT NULL,
		Birthday date NOT NULL,
		[Image] varbinary(max)
	)

CREATE TABLE Beetroot.dbo.History
	(
		Id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		[Date] datetime NOT NULL,
		CustomerId int NOT NULL FOREIGN KEY REFERENCES dbo.Customers(Id),
		BookId int NOT NULL FOREIGN KEY REFERENCES dbo.Books(Id),
	)
