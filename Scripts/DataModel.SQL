USE Timesheet

CREATE TABLE Customer ( 
	Customer_ID int identity(1,1)  NOT NULL,
	CompanyName varchar(255) NOT NULL,
	ContactPerson varchar(255),
	BankAccountNbr varchar(255),
	CreUser varchar(50),
	CreDate datetime,
	ModUser varchar(50),
	ModDate datetime
) 
;

CREATE TABLE Person ( 
	Person_ID int identity(1,1)  NOT NULL,
	FirstName varchar(20),
	LastName varchar(255),
	Email varchar(255),
	IsManager bit NOT NULL,
	DateOfBirth datetime,
	CreUser varchar(50),
	CreDate datetime,
	ModUser varchar(50),
	ModDate datetime
) 
;

CREATE TABLE Person_MM_Project ( 
	Person_ID int NOT NULL,
	Project_ID int NOT NULL
) 
;

CREATE TABLE Project ( 
	Project_ID int identity(1,1)  NOT NULL,
	ProjectName varchar(255) NOT NULL,
	IsBillable bit NOT NULL,
	MaximumWorkHours int,
	CreUser varchar(50),
	CreDate datetime,
	ModUser varchar(50),
	ModDate datetime,
	Customer_ID int NOT NULL,
	Person_ID int NOT NULL
) 
;

CREATE TABLE SecurityControlRight ( 
	SecurityControlRight_ID int identity(1,1)  NOT NULL,
	FormName varchar(255),
	UserControlName varchar(255),
	BusinessName varchar(255),
	CreUser varchar(50),
	CreDate datetime,
	ModUser varchar(50),
	ModDate datetime,
	SecurityRole_ID int NOT NULL,
	SecurityRight_ID int NOT NULL
) 
;

CREATE TABLE SecurityRight ( 
	SecurityRight_ID int identity(1,1)  NOT NULL,
	Name varchar(255),
	CreUser varchar(50),
	CreDate datetime,
	ModUser varchar(50),
	ModDate datetime
) 
;

CREATE TABLE SecurityRole ( 
	SecurityRole_ID int identity(1,1)  NOT NULL,
	Name varchar(255),
	CreUser varchar(50),
	CreDate datetime,
	ModUser varchar(50),
	ModDate datetime
) 
;

CREATE TABLE SecurityRole_MM_SecurityUser ( 
	SecurityRole_ID int NOT NULL,
	SecurityUser_ID int NOT NULL
) 
;

CREATE TABLE SecurityUser ( 
	SecurityUser_ID int identity(1,1)  NOT NULL,
	Name varchar(255),
	CreUser varchar(50),
	CreDate datetime,
	ModUser varchar(50),
	ModDate datetime
) 
;

CREATE TABLE WorkItem ( 
	WorkItem_ID int identity(1,1)  NOT NULL,
	DateWorked datetime NOT NULL,
	HoursWorked money NOT NULL,
	Comments varchar(255),
	CreUser varchar(50),
	CreDate datetime,
	ModUser varchar(50),
	ModDate datetime,
	Person_ID int NOT NULL,
	Project_ID int NOT NULL,
	WorkItemType_ID int NOT NULL
) 
;

CREATE TABLE WorkItemType ( 
	WorkItemType_ID int identity(1,1)  NOT NULL,
	Code varchar(255) NOT NULL,
	Description varchar(255) NOT NULL,
	CreUser varchar(50),
	CreDate datetime,
	ModUser varchar(50),
	ModDate datetime
) 
;


ALTER TABLE Customer ADD CONSTRAINT PK_Customer 
PRIMARY KEY (Customer_ID) 
;

ALTER TABLE Person ADD CONSTRAINT PK_Person 
PRIMARY KEY (Person_ID) 
;

ALTER TABLE Person_MM_Project ADD CONSTRAINT PK_Person_MM_Project 
PRIMARY KEY (Person_ID, Project_ID) 
;

ALTER TABLE Project ADD CONSTRAINT PK_Project 
PRIMARY KEY (Project_ID) 
;

ALTER TABLE SecurityControlRight ADD CONSTRAINT PK_SecurityControlRight 
PRIMARY KEY (SecurityControlRight_ID) 
;

ALTER TABLE SecurityRight ADD CONSTRAINT PK_SecurityRight 
PRIMARY KEY (SecurityRight_ID) 
;

ALTER TABLE SecurityRole ADD CONSTRAINT PK_SecurityRole 
PRIMARY KEY (SecurityRole_ID) 
;

ALTER TABLE SecurityRole_MM_SecurityUser ADD CONSTRAINT PK_SecurityRole_MM_SecurityUser 
PRIMARY KEY (SecurityRole_ID, SecurityUser_ID) 
;

ALTER TABLE SecurityUser ADD CONSTRAINT PK_SecurityUser 
PRIMARY KEY (SecurityUser_ID) 
;

ALTER TABLE WorkItem ADD CONSTRAINT PK_WorkItem 
PRIMARY KEY (WorkItem_ID) 
;

ALTER TABLE WorkItemType ADD CONSTRAINT PK_WorkItemType 
PRIMARY KEY (WorkItemType_ID) 
;


CREATE INDEX IDX_Person_MM_Project__Person_ID
ON Person_MM_Project (Person_ID ASC)
;

CREATE INDEX IDX_Person_MM_Project__Project_ID
ON Person_MM_Project (Project_ID ASC)
;

CREATE INDEX IDX_Project__Customer_ID
ON Project (Customer_ID ASC)
;

CREATE INDEX IDX_Project__Person_ID
ON Project (Person_ID ASC)
;

CREATE INDEX IDX_SecurityControlRight__SecurityRole_ID
ON SecurityControlRight (SecurityRole_ID ASC)
;

CREATE INDEX IDX_SecurityControlRight__SecurityRight_ID
ON SecurityControlRight (SecurityRight_ID ASC)
;

CREATE INDEX IDX_SecurityRole_MM_SecurityUser__SecurityRole_ID
ON SecurityRole_MM_SecurityUser (SecurityRole_ID ASC)
;

CREATE INDEX IDX_SecurityRole_MM_SecurityUser__SecurityUser_ID
ON SecurityRole_MM_SecurityUser (SecurityUser_ID ASC)
;

CREATE INDEX IDX_WorkItem__Person_ID
ON WorkItem (Person_ID ASC)
;

CREATE INDEX IDX_WorkItem__Project_ID
ON WorkItem (Project_ID ASC)
;

CREATE INDEX IDX_WorkItem__WorkItemType_ID
ON WorkItem (WorkItemType_ID ASC)
;



ALTER TABLE Person_MM_Project ADD CONSTRAINT FK_Person_MM_Project__Person 
FOREIGN KEY (Person_ID) REFERENCES Person (Person_ID)
;

ALTER TABLE Person_MM_Project ADD CONSTRAINT FK_Person_MM_Project__Project 
FOREIGN KEY (Project_ID) REFERENCES Project (Project_ID)
;

ALTER TABLE Project ADD CONSTRAINT FK_Project__Customer 
FOREIGN KEY (Customer_ID) REFERENCES Customer (Customer_ID)
;

ALTER TABLE Project ADD CONSTRAINT FK_Project__Person 
FOREIGN KEY (Person_ID) REFERENCES Person (Person_ID)
;

ALTER TABLE SecurityControlRight ADD CONSTRAINT FK_SecurityControlRight__SecurityRole 
FOREIGN KEY (SecurityRole_ID) REFERENCES SecurityRole (SecurityRole_ID)
;

ALTER TABLE SecurityControlRight ADD CONSTRAINT FK_SecurityControlRight__SecurityRight 
FOREIGN KEY (SecurityRight_ID) REFERENCES SecurityRight (SecurityRight_ID)
;

ALTER TABLE SecurityRole_MM_SecurityUser ADD CONSTRAINT FK_SecurityRole_MM_SecurityUser__SecurityRole 
FOREIGN KEY (SecurityRole_ID) REFERENCES SecurityRole (SecurityRole_ID)
;

ALTER TABLE SecurityRole_MM_SecurityUser ADD CONSTRAINT FK_SecurityRole_MM_SecurityUser__SecurityUser 
FOREIGN KEY (SecurityUser_ID) REFERENCES SecurityUser (SecurityUser_ID)
;

ALTER TABLE WorkItem ADD CONSTRAINT FK_WorkItem__Person 
FOREIGN KEY (Person_ID) REFERENCES Person (Person_ID)
;

ALTER TABLE WorkItem ADD CONSTRAINT FK_WorkItem__Project 
FOREIGN KEY (Project_ID) REFERENCES Project (Project_ID)
;

ALTER TABLE WorkItem ADD CONSTRAINT FK_WorkItem__WorkItemType 
FOREIGN KEY (WorkItemType_ID) REFERENCES WorkItemType (WorkItemType_ID)
;
