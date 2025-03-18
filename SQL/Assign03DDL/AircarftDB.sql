-----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------- Question 01 Aircraft ------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------------------
CREATE DATABASE AirCraft; 

use AirCraft

-- Create aircraft table
Create Table AirCraft(
    ID INT PRIMARY KEY IDENTITY(1 ,1),
    Capacity int not null, 
    Model varchar(50) NOT Null, 
    MajoPilot varchar(30), 
    Assistant varchar(20), 
    Host1 varchar(30), 
    Host2 varchar(30),
    AirlineID int, 
);

-- Create Airline table
CREATE TABLE Airline 
(
    ID INT PRIMARY KEY Identity, 
    Name varchar(30) not null, 
    Address varchar(100), 
    ContactPerson varchar(50),
)

-- Create Airline Phone
Create Table AirlinePhone
(
    AirlineID int REFERENCES Airline(ID),
    Phones varchar(20), 
    PRIMARY key(AirlineID, Phones)
)

-- Create Transaction table
Create Table Transactions 
(
    ID INT Primary key identity, 
    Description varchar(200) ,
    Amount money not null, 
    TransactionDate Date, 
    AirlineID int not null REFERENCES Airline(ID),
)

-- Create Employee table
Create Table Employees
(
    EmployeeID INT PRIMARY KEY IDENTITY, 
    EmployeeName varchar(50) not null, 
    Address varchar(100),
    Gender char(1), 
    Position varchar(40) not null, 
    BD_Year int, 
    BD_Month int, 
    BD_Day int, 
    AirlineID int not null REFERENCES Airline(ID)
)

-- Create Employee Qualifications table
Create table EmployeeQualifications 
(
    EmployeeId int REFERENCES Employees(EmployeeID),
    Qualifications varchar(50), 
    PRIMARY KEY (EmployeeID , Qualifications)
)

-- Create Route table
Create TABLE Route 
(
    ID INT PRIMARY KEY IDENTITY, 
    Distance VARCHAR(50) ,
    Description VARCHAR(max) ,
    Origin VARCHAR(50), 
    Classification char(1)
)

-- Aircraft Route table
Create TABLE AircraftRoute 
(
    AircraftID INT REFERENCES Aircraft(ID), 
    RouteID INT REFERENCES Route(ID), 
    PRIMARY key (AircraftID, RouteID), 
    DepartureTime INT , 
    NumberOfPassiners INT, 
    Price money, 
    Arrival Date, 
)

alter TABLE AirCraft
add constraint FK_Owns foreign KEY (ID) REFERENCES  Airline(ID)

DROP TABLE AirCraft

-----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------- Question 02 Hospital ------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------------------
Create DATABASE Hospital

use Hospital

Create TABLE Patients 
(
    ID INT PRIMARY KEY IDENTITY, 
    PatientName varchar(50) NOT NULL, 
    DateOfBirth Date, 
    WarldID int, 
    ConsultantID int,
)

Create Table Wards
(
    WardID int PRIMARY KEY IDENTITY, 
    WardName VARCHAR(50) not null, 
    NurseNumber int, 
)

Create TABLE Nurses 
(
    NurseNumber int PRIMARY KEY IDENTITY, 
    NurseName VARCHAR(50) not null, 
    Address VARCHAR(1000), 
    WardID int REFERENCES Wards(WardID),
)

Create TABLE Consultants
(
    ConsultantID int PRIMARY KEY IDENTITY, 
    ConsultantName VARCHAR(50),
)

Create TABLE PatientConsultants
(
    ConsultantID int REFERENCES Consultants(ConsultantID), 
    PatientId int REFERENCES Patients(ID),
    PRIMARY KEY (ConsultantID, PatientId)
)

Create TABLE Drugs 
(
    DrugCode INT PRIMARY KEY IDENTITY, 
    Dosage VARCHAR(50) not null,
)

Create TABLE DrugBrand
(
    DrugCode int REFERENCES Drugs(DrugCode), 
    Brand VARCHAR(50) not null,
    PRIMARY key(DrugCode , Brand)
)

CREATE TABLE NurseDrugPatient
(
    NurseNumber int REFERENCES Nurses(NurseNumber),
    DrugCode int REFERENCES Drugs(DrugCode), 
    PatientID int REFERENCES Patients(ID), 
    Dates Date, 
    Times INT, 
    Dosage varchar(50),
    PRIMARY key (PatientID, Dates, Times)
)

alter table Patients 
add CONSTRAINT FK_Hosts FOREIGN key (WarldID) REFERENCES Wards(WardID)

alter TABLE Patients
add CONSTRAINT FK_Assigned FOREIGN KEY (ConsultantID) REFERENCES Consultants(ConsultantID)

ALTER Table Wards
add CONSTRAINT FK_Supervised FOREIGN key (NurseNumber) REFERENCES Nurses(NurseNumber)

-----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------- Question 03 ITI -----------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------------------
Create DATABASE ITI

use ITI;

Create TABLE Students 
(
    StudentID INT PRIMARY KEY IDENTITY,
    Fname VARCHAR(30) not null, 
    Lname VARCHAR(30) , 
    Age INT ,
    StudentAddress VARCHAR(100), 
    DepartmentID int,
)

CREATE TABLE Departments 
(
    DepartmentID int PRIMARY key IDENTITY, 
    DepartmentName VARCHAR(50) NOT NULL, 
    HiringDate Date, 
    InstructorID int, 
)

Create Table Instructors 
(
    InstructorId int PRIMARY key IDENTITY, 
    InstructorName VARCHAR(40) NOT NULL, 
    InstructorAddress VARCHAR(100), 
    Bouns money, 
    Salary money NOT NULL, 
    HourRate Money , 
    DepartmentID INT REFERENCES Departments(DepartmentID)
)

Create Table Courses
(
    CourseID int PRIMARY KEY IDENTITY, 
    CourseName VARCHAR(50) not null, 
    CourseDuration int, 
    Description VARCHAR(100), 
    TopicId int,
)

Create Table Topics
(
    TopicId int PRIMARY KEY IDENTITY, 
    TopicName VARCHAR(20),
)


Create Table StudentCourse
(
    StudentID Int REFERENCES Students(StudentID), 
    CourseID int REFERENCES Courses(CourseID), 
    PRIMARY key (StudentID, CourseID),
    Grades FLOAT,
)

Create Table CourseInstructor 
(
    CourseID int REFERENCES Courses(CourseID), 
    InstructorID int REFERENCES Instructors(InstructorID)
    PRIMARY KEY(CourseID, InstructorID)
)

ALTER TABLE Students
add CONSTRAINT FK_Located FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)


ALTER TABLE Departments
add  CONSTRAINT FK_Manage  FOREIGN key (InstructorID) REFERENCES Instructors(InstructorId)


DROP TABLE StudentCourse

-----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------- Question 04 Musican -------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------------------

Create Database Musican

USE Musican

Create Table Musican 
(
    MusicanID INT PRIMARY KEY IDENTITY, 
    Musican VARCHAR(20) NOT NULL, 
    PhoneNumber VARCHAR(15) , 
    City VARCHAR(20) ,
    Street VARCHAR(20),
)

Create Table Instrument
(
    InstrumentName VARCHAR(50) PRIMARY KEY, 
    InstrumentKey VARCHAR(20),
)

Create Table Albums
(
    AlbumID INT PRIMARY KEY IDENTITY, 
    AlbumTitle VARCHAR(50),
    AlbumDate Date, 
    MusicanID int NOT NULL REFERENCES Musican(MusicanID)
)

Create Table Songs
(
    SongTitle VARCHAR(30) PRIMARY key, 
    SongAuthor VARCHAR(50), 
)

Create TABLE AlbumSongs
(
    AlbumID int REFERENCES Albums(AlbumID),
    SongID VARCHAR(30) REFERENCES Songs(SongTitle),
    PRIMARY KEY(AlbumID, SongID)
)

Create Table MusicanSong(
    MusicanID INT REFERENCES Musican(MusicanID),
    SongTitle VARCHAR(30) REFERENCES Songs(SongTitle),
    PRIMARY key(MusicanID, SongTitle)
)

CREATE TABLE MusicanInstrument
(
    MusicanID int REFERENCES Musican(MusicanID),
    InstrumentName VARCHAR(50) REFERENCES Instrument(InstrumentName),
    PRIMARY KEY(MusicanID, InstrumentName)
)

DROP TABLE Musican


-----------------------------------------------------------------------------------------------------------------------------------------------------
------------------------------------------------------------- Question 05 Sales OFFice --------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------------------
Create DATABASE SalesOffice