USE TimeSheet

BEGIN Transaction

DECLARE @user VARCHAR(50)
DECLARE @cust1 INT
DECLARE @cust2 INT
DECLARE @cust3 INT
DECLARE @person1 INT
DECLARE @person2 INT
DECLARE @person3 INT
DECLARE @person4 INT
DECLARE @person5 INT
DECLARE @project1 INT
DECLARE @project2 INT
DECLARE @type1 INT
DECLARE @type2 INT
DECLARE @type3 INT

SET @user = 'venjoha'

--Table SecurityUser
insert into securityUser([Name], CreUser, CreDate) values ('WXP-VENJOHA2\venjoha', @user, getdate())
insert into securityUser([Name], CreUser, CreDate) values ('WV-WITTEEL\witteel', @user, getdate())

--Table Customer
insert into customer(CompanyName, ContactPerson, BankAccountNbr, CreUser, CreDate) 
		values ('Leaf', 'Jef De Wit','000-0000011-11' , @user, getdate())
SELECT @cust1 = SCOPE_IDENTITY()
insert into customer(CompanyName, ContactPerson, BankAccountNbr, CreUser, CreDate) 
		values ('QFrame', 'Ikke','000-0000022-22' , @user, getdate())
SELECT @cust2 = SCOPE_IDENTITY()
insert into customer(CompanyName, ContactPerson, BankAccountNbr, CreUser, CreDate) 
		values ('ACV', 'Luc Kortebeek','000-0000077-77' , @user, getdate())
SELECT @cust3 = SCOPE_IDENTITY()

--Table Person
insert into person(FirstName, LastName, Email, IsManager, DateOfBirth, CreUser, CreDate)
	values('Wouter', 'Janssens', 'wouter.janssens@Leaf.be', 0, '19781121', @user, getdate())
SELECT @person1 = SCOPE_IDENTITY()

insert into person(FirstName, LastName, Email, IsManager, DateOfBirth, CreUser, CreDate)
	values('Ven', 'Johan', 'johan.ven@Leaf.be', '19811208', 0, @user, getdate())
SELECT @person2 = SCOPE_IDENTITY()

insert into person(FirstName, LastName, Email, IsManager, DateOfBirth, CreUser, CreDate)
	values('Gladines', 'Danny', 'danny.gladines@Leaf.be', 1, '19640810', @user, getdate())
SELECT @person3 = SCOPE_IDENTITY()

insert into person(FirstName, LastName, Email, IsManager, DateOfBirth, CreUser, CreDate)
	values('Rauter', 'Jan', 'jan.rauter@Leaf.be', 1, '19730210', @user, getdate())
SELECT @person4 = SCOPE_IDENTITY()

insert into person(FirstName, LastName, Email, IsManager, DateOfBirth, CreUser, CreDate)
	values('Van Langendonck', 'Andy', 'andy.vanlangendonck@Leaf.be', 1, '19750202', @user, getdate())
SELECT @person5 = SCOPE_IDENTITY()

--Table Project
insert into Project(ProjectName, IsBillable, MaximumWorkHours, Customer_ID, Person_ID, CreUser, CreDate)
	values('ACV-Horizon', 1, null, @cust3, @person3, @user, getdate())
SELECT @project1 = SCOPE_IDENTITY()
insert into Project(ProjectName, IsBillable, MaximumWorkHours, Customer_ID, Person_ID, CreUser, CreDate)
	values('Leaf .NET Framework', 0, null, @cust2, @person3, @user, getdate())
SELECT @project2 = SCOPE_IDENTITY()

--Table Person_MM_Project
insert into Person_MM_Project(Person_ID, Project_ID)
		values(@person1, @project2)
insert into Person_MM_Project(Person_ID, Project_ID)
		values(@person2, @project2)
insert into Person_MM_Project(Person_ID, Project_ID)
		values(@person3, @project2)
insert into Person_MM_Project(Person_ID, Project_ID)
		values(@person4, @project2)
insert into Person_MM_Project(Person_ID, Project_ID)
		values(@person5, @project2)
insert into Person_MM_Project(Person_ID, Project_ID)
		values(@person1, @project1)
insert into Person_MM_Project(Person_ID, Project_ID)
		values(@person2, @project1)
insert into Person_MM_Project(Person_ID, Project_ID)
		values(@person5, @project1)

--Table WorkItemType
insert into WorkItemType(Code, Description, CreUser, CreDate)
			values ('DEV', 'Development', @user, getdate())
SELECT @type1 = SCOPE_IDENTITY()

insert into WorkItemType(Code, Description, CreUser, CreDate)
			values ('PM', 'Project Management', @user, getdate())
SELECT @type2 = SCOPE_IDENTITY()

insert into WorkItemType(Code, Description, CreUser, CreDate)
			values ('ANA', 'Analyse', @user, getdate())
SELECT @type3 = SCOPE_IDENTITY()

--Table WorkItem
INSERT into WorkItem([DateWorked], HoursWorked, Comments, Person_ID, Project_ID, WorkItemType_ID, CreUser, CreDate)
	values('20060103', 4.3, 'Techinical analysis', @person1, @project2, @type3, @user, getdate())
INSERT into WorkItem([DateWorked], HoursWorked, Comments, Person_ID, Project_ID, WorkItemType_ID, CreUser, CreDate)
	values('20060104', 8, null, @person1, @project2, @type1, @user, getdate())
INSERT into WorkItem([DateWorked], HoursWorked, Comments, Person_ID, Project_ID, WorkItemType_ID, CreUser, CreDate)
	values('20060103', 2, null, @person2, @project2, @type1, @user, getdate())
INSERT into WorkItem([DateWorked], HoursWorked, Comments, Person_ID, Project_ID, WorkItemType_ID, CreUser, CreDate)
	values('20060103', 3.7, null, @person2, @project2, @type3, @user, getdate())
INSERT into WorkItem([DateWorked], HoursWorked, Comments, Person_ID, Project_ID, WorkItemType_ID, CreUser, CreDate)
	values('20060103', 2.6, null, @person3, @project2, @type2, @user, getdate())
INSERT into WorkItem([DateWorked], HoursWorked, Comments, Person_ID, Project_ID, WorkItemType_ID, CreUser, CreDate)
	values('20060203', 2.6, null, @person4, @project2, @type2, @user, getdate())
INSERT into WorkItem([DateWorked], HoursWorked, Comments, Person_ID, Project_ID, WorkItemType_ID, CreUser, CreDate)
	values('20060203', 6.4, null, @person4, @project2, @type2, @user, getdate())

COMMIT Transaction